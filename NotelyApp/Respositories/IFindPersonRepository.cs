using NotelyApp.Models;
using System;
using System.Collections.Generic;

namespace NotelyApp.Repositories
{
    public interface IFindPersonRepository
    {
        FindPersonModel FindPersonById(Guid id);
        IEnumerable<FindPersonModel> GetAllPersons();
    }
}