using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GigWeb.Models;

namespace GigWeb.Pages.Invitations
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesEventContext _context;

        public IndexModel(RazorPagesEventContext context)
        {
            _context = context;
        }

        public IList<Invitation> Invitation { get;set; }

        public async Task OnGetAsync()
        {
            Invitation = await _context.Invitation.ToListAsync();
        }
    }
}
