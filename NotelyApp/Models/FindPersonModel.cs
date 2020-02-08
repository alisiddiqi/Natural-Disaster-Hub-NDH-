using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyApp.Models
{
    public class FindPersonModel
    {
        public Guid Id { get; set; }
        public string SearchFirstName { get; set; }
        public string SearchLastName { get; set; }
        public string SearchCityOfResidence { get; set; }
    }
}
