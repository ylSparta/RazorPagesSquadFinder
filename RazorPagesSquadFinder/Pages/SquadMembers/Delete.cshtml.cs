using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesSquadFinder.Data;
using RazorPagesSquadFinder.Models;

namespace RazorPagesSquadFinder.Pages.SquadMembers
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext _context;

        public DeleteModel(RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SquadMember SquadMember { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SquadMember = await _context.SquadMember
                .Include(s => s.Member)
                .Include(s => s.Squad).FirstOrDefaultAsync(m => m.SquadMemberId == id);

            if (SquadMember == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SquadMember = await _context.SquadMember.FindAsync(id);

            if (SquadMember != null)
            {
                _context.SquadMember.Remove(SquadMember);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
