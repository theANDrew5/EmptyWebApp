using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public int? Age { get; set; }// знак вопроса говорит о том, что значение может быть null
        public bool IsCorrect { get; set; } = true;
        public void OnGet(string name_, int? age_)
        {
            if (age_.HasValue!=true || age_<1 || age_>110 || string.IsNullOrEmpty(name_))
            {
                IsCorrect = false;
                return;
            }
            Age = age_;
            Name = name_;
        }
    }
}
