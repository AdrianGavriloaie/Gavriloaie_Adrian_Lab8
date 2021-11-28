using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gavriloaie_Adrian_Lab8.Data;
using Gavriloaie_Adrian_Lab8.Models;

namespace Gavriloaie_Adrian_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Gavriloaie_Adrian_Lab8.Data.Gavriloaie_Adrian_Lab8Context _context;

        public IndexModel(Gavriloaie_Adrian_Lab8.Data.Gavriloaie_Adrian_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
