using BootcampCM.Domain.DTOs;
using BootcampCM.Domain.Interfaces;
using BootcampCM.Domain.Models;
using BootcampCM.Infrastructure.Data;
using BootcampCM.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;


namespace BootcampCM.Infrastructure.Services
{
    public class PersonRepository(ApplicationDataContext context) : IPersonRepository
    {
        public readonly ApplicationDataContext _context = context;

        public async Task<bool> Add(Person person)
        {
            await _context.People.AddAsync(person);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Guid id)
        {
            var person = await _context.People.FindAsync(id);

            if (person == null) return false;

            _context.People.Remove(person);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<Person> GetById(Guid id)
        {
            var person = await _context.People.FindAsync(id);
            if (person == null) return null;    
            return person;
        }

        public async Task<bool> Update(Guid id, Person entity)
        {
            var person = await _context.People.FindAsync(id);

            if (person == null) return false;

            person.Name = entity.Name;
            person.Age = entity.Age;
            person.TaxId = entity.TaxId;

            _context.People.Update(person);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
