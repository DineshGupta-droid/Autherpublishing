using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVCDemoApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Gender is required.")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "This Department is required.")]
        public string Department { get; set; }
        [Required(ErrorMessage = "This city is required.")]
        public string City { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "This email is required.")]
        


        public string email { get; set; }
        
    }
}
