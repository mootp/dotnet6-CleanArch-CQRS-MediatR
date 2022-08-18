using System.Text.Json.Serialization;
using App.Domain.Enums;
using MediatR;

namespace App.Application.Features.ToDo.Commands.UpdateToDo;
public class UpdateToDoCommand : IRequest
{
    [JsonConstructor]
    public UpdateToDoCommand()
    {
    }

    public UpdateToDoCommand(string id, string description, int status, string username)
    {
        Id = new Guid(id);
        Description = description;
        Status = (Status)status;
        Username = username;
    }

    public Guid Id { get; set; }

    public string Description { get; set; }

    public Status Status { get; set; }

    public string Username { get; set; }
}