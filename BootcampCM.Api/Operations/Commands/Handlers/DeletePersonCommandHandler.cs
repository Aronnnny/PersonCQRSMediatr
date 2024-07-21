using BootcampCM.Domain.Interfaces;
using MediatR;

namespace BootcampCM.Api.Operations.Commands.Handlers
{
    public class DeletePersonCommandHandler(IPersonRepository repository) : IRequestHandler<DeletePersonCommand, bool>
    {
        private readonly IPersonRepository _personRepository = repository;
        public async Task<bool> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            return await _personRepository.Delete(request.id);
        }
    }
}
