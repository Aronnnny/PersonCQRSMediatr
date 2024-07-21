using BootcampCM.Domain.DTOs;
using BootcampCM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampCM.Infrastructure.Mapping
{
    public static class PersonMapping
    {
        public static PersonDTO ToPersonDTO(this Person person)
        {
            return new PersonDTO
            {
                Id = person.Id,
                Name = person.Name,
                Age = person.Age,
                TaxId = person.TaxId,
            };
        }
    }
}
