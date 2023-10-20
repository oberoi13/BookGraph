using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using kiretfinalexam.Data;
using kiretfinalexam.Models;

namespace kiretfinalexam.Pages.Bookss
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
            return Page();
        }

        [BindProperty]
        public Books Books { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }


            Author A = new Author();
            A.AName = "nanvja";

            Books.Authors.Add(A);
            Author B = new Author();
            A.AName = "Akshu";

            Books.Authors.Add(B);

            _context.Books.Add(Books);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
