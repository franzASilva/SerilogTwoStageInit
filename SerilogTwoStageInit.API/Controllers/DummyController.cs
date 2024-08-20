using MediatR;
using Microsoft.AspNetCore.Mvc;
using SerilogTwoStageInit.API.Queries;

namespace SerilogTwoStageInit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DummyController(ILogger<DummyController> logger) : ControllerBase
{
    [HttpGet(Name = "GetDummies")]
    public async Task<IActionResult> Get(IMediator mediator, CancellationToken ct)
    {
        var dummies = await mediator.Send(new GetAllQuery(), ct);

        if (dummies is null || dummies.Length < 0)
        {
            logger.LogError("GetDummies");
            return NotFound();
        }

        return Ok(dummies);
    }

    [HttpGet("{name}", Name = "GetDummy")]
    public async Task<IActionResult> Get(IMediator mediator, string name, CancellationToken ct)
    {
        var dummy = await mediator.Send(new GetByIdQuery(name), ct);

        if (dummy is null)
        {
            logger.LogError("GetDummy");
            return NotFound();
        }

        return Ok(dummy);
    }
}
