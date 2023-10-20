using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kiretfinalexam.Data;
using kiretfinalexam.Models;

namespace kiretfinalexam.Pages.Bookss
{
    public class DetailsModel : PageModel
    {
        private readonly kiretfinalexam.Data.ExamContext _context;

        public DetailsModel(kiretfinalexam.Data.ExamContext context)
        {
            _context = context;
        }

      public Books Books { get; set; }
        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }
        var books = await _context.Books.FirstOrDefaultAsync(m => m.BooksID == id);
            var authors= await _context.Author.FirstOrDefaultAsync(a => a.AuthorId == id);

            if (books == null)
            {
                return NotFound();
            }
            else 
            {
                Books = books;
            }
            if (authors == null)
            {
                return NotFound();
            }
            else
            {
                Author = authors;
            }

            return Page();

        }
    }
}
