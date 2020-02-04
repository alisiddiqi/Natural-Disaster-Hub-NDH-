using Microsoft.AspNetCore.Mvc;
using NotelyApp.Models;
using NotelyApp.Repositories;
using System;
using System.Diagnostics;
using System.Linq;

namespace NotelyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoteRepository _personRepository;
        public HomeController(INoteRepository noteRepository)
        {
            _personRepository = noteRepository;
        }

        public IActionResult Index()
        {
            var notes = _personRepository.GetAllNotes().Where(n => n.IsDeleted == false);
            return View(notes);
        }

        public IActionResult NoteDetail(Guid id)
        {
            var note = _personRepository.FindNoteById(id);
            return View(note);
        }

        [HttpGet]
        public IActionResult NoteEditor(Guid id = default)
        {
            if (id != Guid.Empty)
            {
                var note = _personRepository.FindNoteById(id);
                return View(note);
            }

            return View();

        }

        [HttpPost]
        public IActionResult NoteEditor(PersonModel personModel)
        {
            if (ModelState.IsValid)
            {
                var date = DateTime.Now;

                if (personModel != null && personModel.Id == Guid.Empty)
                {
                    personModel.Id = Guid.NewGuid();
                    personModel.CreatedDate = date;
                    personModel.LastModified = date;

                    _personRepository.SaveNote(personModel);
                }
                else
                {
                    var person = _personRepository.FindNoteById(personModel.Id);
                    person.LastModified = date;
                    person.Subject = personModel.Subject;
                    person.Detail = personModel.Detail;
                    person.FirstName = personModel.FirstName;
                    person.LastName = personModel.LastName;
                    person.LastKnownLocation = person.LastKnownLocation;
                    
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult DeleteNote(Guid id)
        {
            var note = _personRepository.FindNoteById(id);
            note.IsDeleted = true;

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
