using MediatR;
using SerilogTwoStageInit.Domain.Models;

namespace SerilogTwoStageInit.API.Queries;

internal sealed class GetAllQuery : IRequest<DummyModel[]>
{
}
