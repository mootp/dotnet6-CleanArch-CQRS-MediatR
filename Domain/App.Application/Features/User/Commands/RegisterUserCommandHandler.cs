using App.Application.Interfaces;
using App.Domain.Generics;
using MediatR;

namespace App.Application.Features.User.Commands;
public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Result>
{
    private readonly IIdentityService _identityService;

    public RegisterUserCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<Result> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var result = await _identityService.RegisterUser(request.Email, request.Password);

        return result;
    }
}