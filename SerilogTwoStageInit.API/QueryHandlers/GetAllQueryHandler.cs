using MediatR;
using SerilogTwoStageInit.API.Queries;
using SerilogTwoStageInit.Domain.Models;

namespace SerilogTwoStageInit.API.QueryHandlers;

internal sealed class GetAllQueryHandler(ILogger<GetAllQueryHandler> logger) : IRequestHandler<GetAllQuery, DummyModel[]>
{
    public async Task<DummyModel[]> Handle(GetAllQuery request, CancellationToken ct)
    {
        logger.LogInformation("GetDummies");

        var task = Task.Run(() =>
        {
            return Enumerable.Range(1, 5).Select(index => new DummyModel
            (
                $"Test_{index}",
                DateTime.Now.AddDays(index),
                Random.Shared.Next(-20, 55)
            ))
            .ToArray();
        });

        return await task.WaitAsync(ct);
    }
}
