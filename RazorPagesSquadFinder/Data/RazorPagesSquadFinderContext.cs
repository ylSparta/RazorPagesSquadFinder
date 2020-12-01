using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesSquadFinder.Models;

namespace RazorPagesSquadFinder.Data
{
    public class RazorPagesSquadFinderContext : DbContext
    {
        public RazorPagesSquadFinderContext (DbContextOptions<RazorPagesSquadFinderContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesSquadFinder.Models.Member> Member { get; set; }

        public DbSet<RazorPagesSquadFinder.Models.Squad> Squad { get; set; }
    }
}
