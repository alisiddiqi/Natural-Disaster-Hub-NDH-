using NotelyApp.Models;
using System;
using System.Collections.Generic;

namespace NotelyApp.Repositories
{
    public interface INoteRepository
    {
        void DeleteNote(PersonModel noteModel);
        PersonModel FindNoteById(Guid id);
        IEnumerable<PersonModel> GetAllNotes();
        void SaveNote(PersonModel noteModel);
    }
}