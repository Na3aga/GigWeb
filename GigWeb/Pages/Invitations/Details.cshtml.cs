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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesEventContext _context;

        public DetailsModel(RazorPagesEventContext context)
        {
            _context = context;
        }

        public Invitation Invitation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Invitation = await _context.Invitation.FirstOrDefaultAsync(m => m.invitation_id == id);

            if (Invitation == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
