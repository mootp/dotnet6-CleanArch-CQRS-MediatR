using App.Application.Interfaces;
using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.ToDo;
public class ToDoQueryRepository : IToDoQueryRepository
{
    private readonly AppDbContext _context;

    public ToDoQueryRepository(AppDbContext context)
    {
        _context = context;
        _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public async Task<ToDoItem> GetToDo(Guid id, string username)
    {
        return await _context.ToDoItems.Where(x => x.Id.Equals(id) && x.Username.Equals(username)).SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<ToDoItem>> GetToDoList(string username)
    {
        return await _context.ToDoItems.Where(x => x.Username.Equals(username)).ToListAsync();
    }
}