using BootcampCM.Domain.Models;
using MediatR;

namespace BootcampCM.Api.Operations.Queries
{
    public record GetAllPeopleQuery : IRequest<IEnumerable<Person>>;
}
