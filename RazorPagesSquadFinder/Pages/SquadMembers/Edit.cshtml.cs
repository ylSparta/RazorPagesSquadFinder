using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesSquadFinder.Data;
using RazorPagesSquadFinder.Models;

namespace RazorPagesSquadFinder.Pages.SquadMembers
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext _context;

        public EditModel(RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext context)
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
           ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "MemberId");
           ViewData["SquadId"] = new SelectList(_context.Squad, "SquadId", "SquadId");
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

            _context.Attach(SquadMember).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SquadMemberExists(SquadMember.SquadMemberId))
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

        private bool SquadMemberExists(string id)
        {
            return _context.SquadMember.Any(e => e.SquadMemberId == id);
        }
    }
}
