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
    public class IndexModel : PageModel
    {
        private readonly kiretfinalexam.Data.ExamContext _context;

        public IndexModel(kiretfinalexam.Data.ExamContext context)
        {
            _context = context;
        }

        public IList<Information> Information { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Information != null)
            {
                Information = await _context.Information
                .Include(i => i.Author)
                .Include(i => i.Book).ToListAsync();
            }
        }
    }
}
