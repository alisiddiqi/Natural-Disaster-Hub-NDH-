using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotelyApp.Repositories;

namespace NotelyApp.Controllers
{
    public class FindPerson : Controller
    {
        // GET: /<controller>/
        private readonly IPersonRepository _personRepository;

        public string Index()
        {
            return "This is my default action...";
        }

        [HttpGet]
        public string Search(Guid id = default)
        {
            if (id != Guid.Empty)
            {
                var person = _personRepository.FindPersonById(id);
                return "finding";
            }

            return "not person";
        }
    }
}
