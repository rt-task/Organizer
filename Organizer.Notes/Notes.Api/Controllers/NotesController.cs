using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Notes.Api.Models;
using Notes.Core.Models;
using Notes.Infrastructure.Context;
using Notes.Infrastructure.Models;
using Shared.Abstractions.Models.Api;
using Shared.Abstractions.Models.Response;
using Shared.Helpers;
using static Shared.Helpers.RestApiHelper;

namespace Notes.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class NotesController : ControllerBase
{
    private readonly ILogger<NotesController> _logger;
    private readonly NotesDbContext _ctx;
    private readonly IMapper _mapper;

    public NotesController(
        ILogger<NotesController> logger,
        NotesDbContext ctx,
        IMapper mapper)
    {
        _logger = logger;
        _ctx = ctx;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(typeof(PaginatedResponse<ICollection<Note>, Note>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get([FromQuery] FilteredAndPaginetedRequest request) =>
        await ExecuteAsync(
            Ok,
            async () =>
                {
                    var (filteredSource, countTask) = _ctx.Notes.Filter(request).PaginateAndCount(request);
                    var count = await countTask;
                    var pageResults = await filteredSource.ToArrayAsync();
                    return Tuple.Create(new PaginatedResponse<ICollection<Note>, Note>(pageResults, count));
                },
            _logger);

    [HttpGet("id")]
    [ProducesResponseType(typeof(ResultInfo<Note>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResultInfo<Note>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id) =>
        await ExecuteAsync
            <ResultInfo<Note>, OkObjectResult, InvalidOperationException, string, BadRequestObjectResult>(
                Ok,
                async () =>
                    {
                        var note = await _ctx.Notes.SingleAsync(e => e.Id == id);
                        return new ResultInfo<Note>(note);
                    },
                BadRequest,
                () => "Note not found",
                _logger);

    [HttpPost]
    [ProducesResponseType(typeof(ResultInfo<Note>), StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Create(Note request) =>
        await ExecuteAsync(
            NoContent,
            async () =>
                {
                    var note = _mapper.Map<NoteEntity>(request);
                    await _ctx.Notes.Add(note).Context.SaveChangesAsync();
                },
            _logger);

}