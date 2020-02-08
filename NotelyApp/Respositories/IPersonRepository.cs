using NotelyApp.Models;
using System;
using System.Collections.Generic;

namespace NotelyApp.Repositories
{
    public interface IPersonRepository
    {
        void DeleteNote(PersonModel personModel);
        PersonModel FindPersonById(Guid id);
        IEnumerable<PersonModel> GetAllPersons();
        void SavePerson(PersonModel personModel);
    }
}