using BootcampCM.Domain.Interfaces;
using BootcampCM.Domain.Models;
using MediatR;

namespace BootcampCM.Api.Operations.Queries.Handlers
{
    public class GetAllPeopleQueryHandler(IPersonRepository repository) : IRequestHandler<GetAllPeopleQuery, IEnumerable<Person>>
    {
        private readonly IPersonRepository _personRepository = repository;
        public Task<IEnumerable<Person>> Handle(GetAllPeopleQuery request, CancellationToken cancellationToken)
        {
            return _personRepository.GetAll();
        }
    }
}
