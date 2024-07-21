using BootcampCM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampCM.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAll();
        Task<Person> GetById(Guid id);
        Task<bool> Add(Person person);
        Task<bool> Update(Guid id, Person person);
        Task<bool> Delete(Guid id);
    }
}
