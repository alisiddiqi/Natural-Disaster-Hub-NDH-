using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotelyApp.Models;

namespace NotelyApp.Repositories
{
    public class FindPersonRepository : IFindPersonRepository
    {
        private readonly List<FindPersonModel> _findPerson;

        public FindPersonRepository()
        {
            _findPerson = new List<FindPersonModel>();
        }

        public FindPersonModel FindPersonById(Guid id)
        {
            var findPerson = _findPerson.Find(n => n.Id == id);

            return findPerson;
        }

        public IEnumerable<FindPersonModel> GetAllPersons()
        {
            return _findPerson;
        }
    }
}
