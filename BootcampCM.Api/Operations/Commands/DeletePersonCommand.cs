using MediatR;

namespace BootcampCM.Api.Operations.Commands
{
    public record DeletePersonCommand(Guid id) : IRequest<bool>;
}
