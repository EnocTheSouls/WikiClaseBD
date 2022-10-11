using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WikiClase.Data;
using WikiClase.Models;

namespace WikiClase.Pages.Tags
{
    public class IndexModel : PageModel
    {
        private readonly WikiClase.Data.ApplicationDbContext _context;

        public IndexModel(WikiClase.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Tag> Tag { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Tag != null)
            {
                Tag = await _context.Tag
                .Include(t => t.Categorias).ToListAsync();
            }
        }
    }
}
