using BootcampCM.Domain.Models;
using MediatR;

namespace BootcampCM.Api.Operations.Commands
{
    public record CreatePersonCommand(string name, int age, string taxId) : IRequest<bool>;
}
