using App.Domain.Entities;
using MediatR;

namespace App.Application.Features.ToDo.Queries;
public class GetToDoListQuery : IRequest<List<ToDoItem>>
{
    public GetToDoListQuery(string username)
    {
        Username = username;
    }

    public string Username { get; private set; }
}