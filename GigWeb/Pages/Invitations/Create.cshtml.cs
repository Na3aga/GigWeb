using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GigWeb.Models;

namespace GigWeb.Pages.Invitations
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesEventContext _context;

        public CreateModel(RazorPagesEventContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Invitation Invitation { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Invitation.Add(Invitation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
