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
    public class IndexModel : PageModel
    {
        private readonly Vintan_Oana_Laborator6.Data.Vintan_Oana_Laborator6Context _context;

        public IndexModel(Vintan_Oana_Laborator6.Data.Vintan_Oana_Laborator6Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
