using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyWebApp.Pages
{
    public class PersonModel : PageModel
    {
        public string Message { get; set; }


        [BindProperty]
        public Models.Person Person { get; set; }

        public void OnGet()
        {
            Message = "Введите данные";
        }
        public void OnPost()
        {
            Message = $"Имя:\t{Person.Name}\nВозраст:\t{Person.Age}";//Литераллы не работают 
        }
    }
}
