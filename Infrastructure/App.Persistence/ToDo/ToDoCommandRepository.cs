using App.Application.Interfaces;
using App.Domain.Entities;

namespace App.Persistence.ToDo;
public class ToDoCommandRepository : IToDoCommandRepository
{
    private readonly AppDbContext _context;

    public ToDoCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task CreateToDo(ToDoItem toDo)
    {
        _context.Add(toDo);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateToDo(ToDoItem toDo)
    {
        _context.Update(toDo);
        await _context.SaveChangesAsync();
    }
}