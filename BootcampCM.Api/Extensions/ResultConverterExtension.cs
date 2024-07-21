using BootcampCM.Api.Result;
using BootcampCM.Domain.DTOs;
using BootcampCM.Domain.Models;

namespace BootcampCM.Api.Extensions
{
    public static class ResultConverterExtension
    {
        public static PersonResult ToPersonResult(this PersonDTO personDTO)
        {
            return new PersonResult
            {
                Id = personDTO.Id,
                Name = personDTO.Name,
                Age = personDTO.Age,
                TaxId = personDTO.TaxId,
            };
        }
    }
}
