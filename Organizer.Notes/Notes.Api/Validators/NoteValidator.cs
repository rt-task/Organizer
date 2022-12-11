using FluentValidation;
using Notes.Core.Models;

namespace Notes.Api.Validators
{
    public class NoteValidator : AbstractValidator<Note>
    {
        public NoteValidator()
        {
            RuleFor(obj => obj.Title).NotEmpty();
            RuleFor(obj => obj.Description).NotEmpty();
        }
    }
}
