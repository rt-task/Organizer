using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Notes.Infrastructure.Context;
using Notes.Infrastructure.Mapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidatorsFromAssemblyContaining<Program>();
builder.Services.AddDbContext<NotesDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("AppDbConnection")));
builder.Services.AddAutoMapper(typeof(MappingProfiles));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
