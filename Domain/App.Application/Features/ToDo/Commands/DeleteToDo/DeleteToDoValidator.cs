using FluentValidation;

namespace App.Application.Features.ToDo.Commands.DeleteToDo;
public class DeleteToDoValidator : AbstractValidator<DeleteToDoCommand>
{
    public DeleteToDoValidator()
    {
        RuleFor(x => x.Id).NotNull();
        RuleFor(x => x.Username).NotEmpty();
    }
}