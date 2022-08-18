using App.Domain.Enums;
using FluentValidation;

namespace App.Application.Features.ToDo.Commands.UpdateToDo;
public class UpdateToDoValidator : AbstractValidator<UpdateToDoCommand>
{
    public UpdateToDoValidator()
    {
        RuleFor(x => x.Id).NotNull();
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.Status).NotEqual(Status.None);
        RuleFor(x => x.Username).NotEmpty();
    }
}