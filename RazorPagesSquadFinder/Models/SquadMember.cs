using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSquadFinder.Models
{
    public class SquadMember
    {
        public string SquadMemberId { get; set; }
        public string SquadId { get; set; }
        public string MemberId { get; set; }

        public  Member Member { get; set; }
        public  Squad Squad { get; set; }
    }
}
