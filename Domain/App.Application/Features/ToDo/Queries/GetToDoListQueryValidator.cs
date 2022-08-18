using FluentValidation;

namespace App.Application.Features.ToDo.Queries;
public class GetToDoListQueryValidator : AbstractValidator<GetToDoListQuery>
{
    public GetToDoListQueryValidator()
    {
        RuleFor(x => x.Username).NotEmpty();
    }
}