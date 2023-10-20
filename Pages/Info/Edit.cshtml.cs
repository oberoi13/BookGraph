using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kiretfinalexam.Data;
using kiretfinalexam.Models;

namespace kiretfinalexam.Pages.Info
{
    public class EditModel : PageModel
    {
        private readonly kiretfinalexam.Data.ExamContext _context;

        public EditModel(kiretfinalexam.Data.ExamContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Information Information { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Information == null)
            {
                return NotFound();
            }

            var information =  await _context.Information.FirstOrDefaultAsync(m => m.ID == id);
            if (information == null)
            {
                return NotFound();
            }
            Information = information;
           ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId");
           ViewData["BooksID"] = new SelectList(_context.Books, "BooksID", "BooksID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Information).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InformationExists(Information.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InformationExists(int id)
        {
          return _context.Information.Any(e => e.ID == id);
        }
    }
}
