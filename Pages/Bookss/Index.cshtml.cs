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
    public class IndexModel : PageModel
    {
        private readonly kiretfinalexam.Data.ExamContext _context;

        public IndexModel(kiretfinalexam.Data.ExamContext context)
        {
            _context = context;
        }

        public IList<Books> Books { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                Books = await _context.Books.ToListAsync();
            }
        }
    }
}
