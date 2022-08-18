using App.Domain.Generics;
using MediatR;

namespace App.Application.Features.User.Commands;
public class RegisterUserCommand : IRequest<Result>
{
    public string Email { get; set; }

    public string Password { get; set; }
}