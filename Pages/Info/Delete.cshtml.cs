using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kiretfinalexam.Data;
using kiretfinalexam.Models;

namespace kiretfinalexam.Pages.Info
{
    public class DeleteModel : PageModel
    {
        private readonly kiretfinalexam.Data.ExamContext _context;

        public DeleteModel(kiretfinalexam.Data.ExamContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Information Information { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Information == null)
            {
                return NotFound();
            }

            var information = await _context.Information.FirstOrDefaultAsync(m => m.ID == id);

            if (information == null)
            {
                return NotFound();
            }
            else 
            {
                Information = information;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Information == null)
            {
                return NotFound();
            }
            var information = await _context.Information.FindAsync(id);

            if (information != null)
            {
                Information = information;
                _context.Information.Remove(Information);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
