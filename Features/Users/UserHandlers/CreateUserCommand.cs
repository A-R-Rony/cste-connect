using CsteConnect.Application.Interfaces;
using CsteConnect.Domain.Models;
using ErrorOr;
using FluentValidation;
using MediatR;

namespace CsteConnect.Features.Users.UserHandlers;

public record CreateUserCommand(
    string? Email,
    string Password
) : IRequest<ErrorOr<User>>;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithErrorCode(StatusCodes.Status400BadRequest.ToString())
            .WithMessage("email is required.");

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithErrorCode(StatusCodes.Status400BadRequest.ToString())
            .WithMessage("password is required.");
    }
}

public class CreateUserCommandHandler(
    IUserRepository userRepository
) : IRequestHandler<CreateUserCommand, ErrorOr<User>>
{
    public async Task<ErrorOr<User>> Handle(
        CreateUserCommand command, CancellationToken cancellationToken)
    {
        var user = new User(
        );
        user.Email = command.Email;
        user.Password = command.Password;
        var result = userRepository.Add(user);
        return result.ToErrorOr();
    }
}
