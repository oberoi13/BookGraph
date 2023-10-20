using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using kiretfinalexam.Data;
using kiretfinalexam.Models;

namespace kiretfinalexam.Pages.Info
{
    public class CreateModel : PageModel
    {
        private readonly kiretfinalexam.Data.ExamContext _context;

        public CreateModel(kiretfinalexam.Data.ExamContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId");
        ViewData["BooksID"] = new SelectList(_context.Books, "BooksID", "BooksID");
            return Page();
        }

        [BindProperty]
        public Information Information { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Information.Add(Information);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
