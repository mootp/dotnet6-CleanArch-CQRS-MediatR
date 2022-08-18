using App.Application.Features.ToDo.Events;
using App.Application.Interfaces;
using MediatR;

namespace App.Application.Features.ToDo.Commands.UpdateToDo;
public class UpdateToDoCommandHandler : IRequestHandler<UpdateToDoCommand>
{
    private readonly IToDoCommandRepository _commandRepository;
    private readonly IToDoQueryRepository _queryRepository;
    private readonly IMediator _mediator;

    public UpdateToDoCommandHandler(
        IToDoCommandRepository commandRepository,
        IToDoQueryRepository queryRepository,
        IMediator mediator)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _mediator = mediator;
    }

    public async Task<Unit> Handle(UpdateToDoCommand request, CancellationToken cancellationToken)
    {
        var toDo = await _queryRepository.GetToDo(request.Id, request.Username);
        toDo.SetDescription(request.Description);
        toDo.SetStatus(request.Status);

        await _commandRepository.UpdateToDo(toDo);
        await _mediator.Publish(new TaskUpdatedEvent(toDo.Username, toDo.Description, toDo.Status), cancellationToken);

        return Unit.Value;
    }
}