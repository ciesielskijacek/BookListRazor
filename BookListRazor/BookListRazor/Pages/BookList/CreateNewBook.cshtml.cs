using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor
{
    public class CreateNewBookModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public CreateNewBookModel(ApplicationDbContext aDb)
        {
            db = aDb;
        }

        public Book Book { get; set; }
            
        public void OnGet()
        {

        }
    }
}