using Notes.Core.Models;
using Shared.Abstractions.Models.Relational;

namespace Notes.Infrastructure.Models;

public class NoteEntity : Note, IEntity<int>
{
    public int Id { get; set; }
    public int UserId { get; set; }
}