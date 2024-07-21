using Azure.Core;
using BootcampCM.Domain.Interfaces;
using BootcampCM.Domain.Models;
using BootcampCM.Infrastructure.Data;
using MediatR;
using System;

namespace BootcampCM.Api.Operations.Commands.Handlers
{
    public class CreatePersonCommandHandler(IPersonRepository repository) : IRequestHandler<CreatePersonCommand, bool>
    {
        private readonly IPersonRepository _personRepository = repository;
        public async Task<bool> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = new Person
            {
                Name = request.name,
                Age = request.age,
                TaxId = request.taxId,
            };

            return await _personRepository.Add(person);
        }
    }
}
