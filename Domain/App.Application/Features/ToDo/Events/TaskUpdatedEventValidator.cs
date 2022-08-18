using App.Domain.Enums;
using FluentValidation;

namespace App.Application.Features.ToDo.Events;
public class TaskUpdatedEventValidator : AbstractValidator<TaskUpdatedEvent>
{
    public TaskUpdatedEventValidator()
    {
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.Email).NotEmpty();
        RuleFor(x => x.Status).NotEqual(Status.None);
    }
}