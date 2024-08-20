using MediatR;
using SerilogTwoStageInit.API.Queries;
using SerilogTwoStageInit.Domain.Models;

namespace SerilogTwoStageInit.API.QueryHandlers;

internal sealed class GetByIdQueryHandler(ILogger<GetByIdQueryHandler> logger) : IRequestHandler<GetByIdQuery, DummyModel>
{
    public async Task<DummyModel> Handle(GetByIdQuery request, CancellationToken ct)
    {
        logger.LogInformation("GetDummy");

        var task = Task.Run(() =>
        {
            return new DummyModel
            (
                request.Name,
                DateTime.Now,
                Random.Shared.Next(-20, 55)
            );
        });

        return await task.WaitAsync(ct);
    }
}
