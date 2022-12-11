using Microsoft.EntityFrameworkCore;
using Notes.Infrastructure.Models;

namespace Notes.Infrastructure.Context;

public class NotesDbContext : DbContext
{
	public DbSet<NoteEntity> Notes { get; set; }

	public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
	{
	}
}
