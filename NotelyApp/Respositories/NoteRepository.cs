using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotelyApp.Models;

namespace NotelyApp.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly List<PersonModel> _notes;

        public NoteRepository()
        {
            _notes = new List<PersonModel>();
        }

        public PersonModel FindNoteById(Guid id)
        {
            var note = _notes.Find(n => n.Id == id);

            return note;
        }

        public IEnumerable<PersonModel> GetAllNotes()
        {
            return _notes;
        }

        public void SaveNote(PersonModel noteModel)
        {
            _notes.Add(noteModel);
        }

        public void DeleteNote(PersonModel noteModel)
        {
            _notes.Remove(noteModel);
        }
    }
}
