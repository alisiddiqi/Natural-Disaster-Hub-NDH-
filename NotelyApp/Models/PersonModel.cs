using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace NotelyApp.Models
{
    public class PersonModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please enter the subject")]
        public string Subject { get; set; }
        public string Detail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityOfResidence { get; set; }
        public string LastKnownLocation { get; set; }
       
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}
