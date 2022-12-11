using AutoMapper;
using Notes.Core.Models;
using Notes.Infrastructure.Models;

namespace Notes.Infrastructure.Mapper;

public class MappingProfiles : Profile
{
	public MappingProfiles()
	{
		CreateMap<Note, NoteEntity>();
	}
}
