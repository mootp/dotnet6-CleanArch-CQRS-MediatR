using App.Application.Interfaces;
using App.Domain.Entities;
using App.Domain.Enums;
using MediatR;

namespace App.Application.Features.ToDo.Queries;
public class GetTaskListQueryHandler : IRequestHandler<GetToDoListQuery, List<ToDoItem>>
{
    private readonly IToDoQueryRepository _queryRepository;

    public GetTaskListQueryHandler(IToDoQueryRepository toDoRepository)
    {
        _queryRepository = toDoRepository;
    }

    public async Task<List<ToDoItem>> Handle(GetToDoListQuery request, CancellationToken cancellationToken)
    {
        var toDoList = await _queryRepository.GetToDoList(request.Username);
        return toDoList.Where(x => x.Status != Status.Deleted).ToList();
    }
}