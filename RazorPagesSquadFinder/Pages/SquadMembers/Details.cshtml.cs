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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext _context;

        public DetailsModel(RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext context)
        {
            _context = context;
        }

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
    }
}
