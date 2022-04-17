using MediatorHandler.Common.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace MediatorHandler.API.Utils;

[ApiController]
public abstract class BaseController : ControllerBase
{
    protected List<string> Errors = new List<string>();

    protected ActionResult CustomResponse(object result = null)
    {
        if (ValidateOperation())
        {
            return Ok(result);
        }

        return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
        {
            { "Messages", Errors.ToArray() }
        }));
    }

    protected ActionResult CustomResponse(MediatorResult result)
    {
        foreach (string error in result.Errors)
        {
            AddProcessingError(error);
        }

        return CustomResponse(result.Response);
    }

    protected ActionResult CustomResponse(List<String> Errors)
    {
        foreach (var error in Errors)
        {
            AddProcessingError(error);
        }

        return CustomResponse();
    }


    protected bool ValidateOperation()
    {
        return !Errors.Any();
    }

    protected void AddProcessingError(string error)
    {
        Errors.Add(error);
    }
}
