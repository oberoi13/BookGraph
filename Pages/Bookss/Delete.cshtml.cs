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
    public class DeleteModel : PageModel
    {
        private readonly kiretfinalexam.Data.ExamContext _context;

        public DeleteModel(kiretfinalexam.Data.ExamContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Books Books { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var books = await _context.Books.FirstOrDefaultAsync(m => m.BooksID == id);

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }
            var books = await _context.Books.FindAsync(id);

            if (books != null)
            {
                Books = books;
                _context.Books.Remove(Books);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
