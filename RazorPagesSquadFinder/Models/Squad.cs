using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSquadFinder.Models
{
    public class Squad
    {
        public string SquadId { get; set; }
        public string SquadLeader { get; set; }
        public int NoOfSquadMembers { get; set; }
        public string Sport { get; set; }
    }
}
