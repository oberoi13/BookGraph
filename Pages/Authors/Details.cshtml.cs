using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kiretfinalexam.Data;
using kiretfinalexam.Models;

namespace kiretfinalexam.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly kiretfinalexam.Data.ExamContext _context;

        public DetailsModel(kiretfinalexam.Data.ExamContext context)
        {
            _context = context;
        }

      public Author Author { get; set; }
        public Books Books { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }
            var books = await _context.Books.FirstOrDefaultAsync(m => m.BooksID == id);
            var author = await _context.Author.FirstOrDefaultAsync(m => m.AuthorId == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            if (books == null)
            {
                return NotFound();
            }
            else
            {
                Books = books;
            }
            return Page();
        }
    }
}
