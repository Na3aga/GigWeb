using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GigWeb.Models;

namespace GigWeb.Pages.Invitations
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesEventContext _context;

        public EditModel(RazorPagesEventContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Invitation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvitationExists(Invitation.invitation_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InvitationExists(int id)
        {
            return _context.Invitation.Any(e => e.invitation_id == id);
        }
    }
}
