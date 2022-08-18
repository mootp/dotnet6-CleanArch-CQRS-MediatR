using App.Domain.Entities;

namespace App.Application.Interfaces;
public interface IToDoCommandRepository
{
    Task CreateToDo(ToDoItem toDo);

    Task UpdateToDo(ToDoItem toDo);
}