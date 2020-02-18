using Microsoft.AspNetCore.Mvc;
using NotelyApp.Models;
using NotelyApp.Repositories;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonRepository _personRepository;
        public HomeController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IActionResult Index()
        {
            var persons = _personRepository.GetAllPersons().Where(n => n.IsDeleted == false);
            return View(persons);
        }

        public IActionResult PersonDetail(Guid id)
        {
            var person = _personRepository.FindPersonById(id);
            return View(person);
        }

        [HttpGet]
        public IActionResult PersonEditor(Guid id = default)
        {
            if (id != Guid.Empty)
            {
                var person = _personRepository.FindPersonById(id);
                return View(person);
            }

            return View();
        }

     

        [HttpPost]
        public IActionResult PersonEditor(PersonModel personModel)
        {
            if (ModelState.IsValid)
            {
                var date = DateTime.Now;

                if (personModel != null && personModel.Id == Guid.Empty)
                {
                    personModel.Id = Guid.NewGuid();
                    personModel.CreatedDate = date;
                    personModel.LastModified = date;

                    _personRepository.SavePerson(personModel);
                }
                else
                {
                    var person = _personRepository.FindPersonById(personModel.Id);
                    person.LastModified = date;
                    person.Subject = personModel.Subject;
                    person.Detail = personModel.Detail;
                    person.FirstName = personModel.FirstName;
                    person.LastName = personModel.LastName;
                    person.LastKnownLocation = person.LastKnownLocation;
                    _personRepository.EditPerson(person);
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult DeletePerson(Guid id)
        {
            var person = _personRepository.FindPersonById(id);
            person.IsDeleted = true;

            _personRepository.DeleteNote(person);

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
