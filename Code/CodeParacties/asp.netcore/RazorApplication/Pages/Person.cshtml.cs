using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApplication.Data;

namespace RazorApplication.Pages
{
    public class PersonModel : PageModel
    {
        [BindProperty]
        public Person objPerson { get; set; } = new Person();

        public void OnGet()
        {
            objPerson = new Person()
            {
                ID = 1,
                Address = "Address",
                Email = "lakshaman.rokade@sagitec.com",
                Name = "Lakshaman Rokade",
                Phone = "+14315579302",
                PhoneNumber = "+919766176179"
            };
        }
        public void OnPost()
        {

            objPerson = new Person()
            {
                ID = 1,
                Address = "Address",
                Email = "lakshaman.rokade@sagitec.com",
                Name = "Lakshaman Rokade",
                Phone = "+14315579302",
                PhoneNumber = "+919766176179"
            };
        }
    }
}
