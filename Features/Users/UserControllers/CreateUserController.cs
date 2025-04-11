using CsteConnect.Features.Users.UserHandlers;
using CsteConnect.Presentation.Contacts.Requests;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CsteConnect.Features.Users.UserControllers;

public class CreateUserController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateUser(UserRequest request)
    {
         var command = request.Adapt<CreateUserCommand>();
         var result = await mediator.Send(command);
         var response = result.Match(user => Ok());
       // return Ok(result);
    }
    
}
