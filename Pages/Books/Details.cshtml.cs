using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vintan_Oana_Laborator6.Data;
using Vintan_Oana_Laborator6.Models;

namespace Vintan_Oana_Laborator6.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Vintan_Oana_Laborator6.Data.Vintan_Oana_Laborator6Context _context;

        public DetailsModel(Vintan_Oana_Laborator6.Data.Vintan_Oana_Laborator6Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
