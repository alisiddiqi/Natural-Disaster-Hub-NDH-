using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotelyApp.Models;

namespace NotelyApp.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly List<PersonModel> _person;

        public PersonRepository()
        {
            _person = new List<PersonModel>();
        }

        public PersonModel FindPersonById(Guid id)
        {
            var person = _person.Find(n => n.Id == id);

            return person;
        }

        public IEnumerable<PersonModel> GetAllPersons()
        {
            return _person;
        }

        public void SavePerson(PersonModel personModel)
        {
            _person.Add(personModel);
        }

        public void DeleteNote(PersonModel personModel)
        {
            _person.Remove(personModel);
        }
    }
}
