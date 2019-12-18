using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext mDB;

        public IndexModel (ApplicationDbContext db)
        {
            mDB = db;
        }

        public IEnumerable<Book> Books { get; set; }


        public async Task OnGet()
        {
            Books = await mDB.Book.ToListAsync();
        }
    }
}