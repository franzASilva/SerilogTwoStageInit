using MediatR;
using SerilogTwoStageInit.Domain.Models;

namespace SerilogTwoStageInit.API.Queries;

internal sealed record GetByIdQuery(string Name) : IRequest<DummyModel>;
