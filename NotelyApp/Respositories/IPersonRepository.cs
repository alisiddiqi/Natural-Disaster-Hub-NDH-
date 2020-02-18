using NotelyApp.Models;
using System;
using System.Collections.Generic;

namespace NotelyApp.Repositories
{
    public interface IPersonRepository
    {
        PersonModel FindPersonById(Guid id);
        PersonModel FindPersonByName(string id);
        
        IEnumerable<PersonModel> GetAllPersons();
        void SavePerson(PersonModel personModel);
        void EditPerson(PersonModel personModel);
        void DeleteNote(PersonModel personModel);

    }
}