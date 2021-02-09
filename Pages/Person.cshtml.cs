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
            Message = "������� ������";
        }
        public void OnPost()
        {
            Message = $"���:\t{Person.Name}\n�������:\t{Person.Age}";//��������� �� �������� 
        }
    }
}
