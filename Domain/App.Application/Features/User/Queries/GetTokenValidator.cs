using FluentValidation;

namespace App.Application.Features.User.Queries;
public class GetTokenValidator : AbstractValidator<GetTokenQuery>
{
    public GetTokenValidator()
    {
        RuleFor(x => x.Password).NotEmpty();
        RuleFor(x => x.Username).NotEmpty();
    }
}