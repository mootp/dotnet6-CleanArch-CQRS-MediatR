using App.Application.Interfaces;
using App.Domain.Entities;
using MediatR;

namespace App.Application.Features.ToDo.Commands.CreateToDo;
public class CreateToDoCommandHandler : IRequestHandler<CreateToDoCommand>
{
    private readonly IToDoCommandRepository _commandRepository;

    public CreateToDoCommandHandler(IToDoCommandRepository commandRepository)
    {
        _commandRepository = commandRepository;
    }

    public async Task<Unit> Handle(CreateToDoCommand request, CancellationToken cancellationToken)
    {
        var toDo = new ToDoItem(request.Id, request.Description, request.Username);
        await _commandRepository.CreateToDo(toDo);

        return Unit.Value;
    }
}