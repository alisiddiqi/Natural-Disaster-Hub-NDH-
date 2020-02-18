using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotelyApp.Models;
using NotelyApp.Migrations;

namespace NotelyApp.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonDbContext _context;

        public PersonRepository(PersonDbContext context)
        {
            _context = context;
        }

        public PersonModel FindPersonById(Guid id)
        {
            var person = _context.Persons.Find(id);
            return person;
        }
        public PersonModel FindPersonByName(string id) // check it out later
        {
            var person = _context.Persons.Find(id);
            return person;
        }

        public IEnumerable<PersonModel> GetAllPersons()
        {
            var persons = _context.Persons;
            return persons;
        }

        public void SavePerson(PersonModel person)
        {
            _context.Add(person);
            _context.SaveChanges();
        }

        public void EditPerson(PersonModel person)
        {
            _context.Persons.Update(person);
            _context.SaveChanges();
        }

        public void DeleteNote(PersonModel person)
        {
            _context.SaveChanges();
        }
    }
}
