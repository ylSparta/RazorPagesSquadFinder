using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesSquadFinder.Data;
using RazorPagesSquadFinder.Models;

namespace RazorPagesSquadFinder.Pages.SquadMembers
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext _context;

        public CreateModel(RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "MemberId");
        ViewData["SquadId"] = new SelectList(_context.Squad, "SquadId", "SquadId");
            return Page();
        }

        [BindProperty]
        public SquadMember SquadMember { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SquadMember.Add(SquadMember);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
