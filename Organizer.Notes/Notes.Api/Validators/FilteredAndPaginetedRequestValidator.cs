using FluentValidation;
using Notes.Api.Models;

namespace Notes.Api.Validators;

public class FilteredAndPaginetedRequestValidator : AbstractValidator<FilteredAndPaginetedRequest>
{
    public FilteredAndPaginetedRequestValidator()
    {
        RuleFor(obj => obj.PageIndex)
            .GreaterThan(0);

        RuleFor(obj => obj.PageSize)
            .GreaterThan(0)
            .LessThanOrEqualTo(100);
    }
}
