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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext _context;

        public IndexModel(RazorPagesSquadFinder.Data.RazorPagesSquadFinderContext context)
        {
            _context = context;
        }

        public IList<SquadMember> SquadMember { get;set; }

        public async Task OnGetAsync()
        {
            SquadMember = await _context.SquadMember
                .Include(s => s.Member)
                .Include(s => s.Squad).ToListAsync();
        }
    }
}
