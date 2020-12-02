using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesSquadFinder.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSquadFinder.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesSquadFinderContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesSquadFinderContext>>()))
            {
                // Look for any squads.
                if (context.Squad.Any())
                {
                    return;   // DB has been seeded
                }

                // Look for any squads members.
                if (context.SquadMember.Any())
                {
                    return;   // DB has been seeded
                }

                if (context.Member.Any())
                {
                    return;   // DB has been seeded
                }



                context.Squad.AddRange(
                    new Squad
                    {
                        SquadId = "9383021",
                        SquadLeader = "Frank Lampard",
                        NoOfSquadMembers = 5,
                        Sport = "Football"
                    },

                    new Squad
                    {
                        SquadId = "1919073",
                        SquadLeader = "Anthony Barry",
                        NoOfSquadMembers = 5,
                        Sport = "Football"
                    }
                );

                context.Member.AddRange(
                    new Member
                    {
                        MemberId = "00393",
                        FirstName = "Reece",
                        LastName = "James"
                    },

                    new Member
                    {
                        MemberId = "00001",
                        FirstName = "Mason",
                        LastName = "Mount"
                    },

                    new Member
                    {
                        MemberId = "00002",
                        FirstName = "Sadio",
                        LastName = "Mane"
                    },

                    new Member
                    {
                        MemberId = "00003",
                        FirstName = "James",
                        LastName = "Milner"
                    },

                    new Member
                    {
                        MemberId = "00004",
                        FirstName = "John",
                        LastName = "Terry"
                    },

                    new Member
                    {
                        MemberId = "03930",
                        FirstName = "Kurt",
                        LastName = "Zouma"
                    },

                    new Member
                    {
                        MemberId = "01002",
                        FirstName = "Ben",
                        LastName = "Chillwell"
                    },

                    new Member
                    {
                        MemberId = "29390",
                        FirstName = "Hakim",
                        LastName = "Ziyech"
                    },

                    new Member
                    {
                        MemberId = "29312",
                        FirstName = "Timo",
                        LastName = "Werner"
                    },

                    new Member
                    {
                        MemberId = "28199",
                        FirstName = "Kai",
                        LastName = "Havertz"
                    }


                   );

                context.SquadMember.AddRange(
                    new SquadMember
                    {
                        SquadMemberId = "00393-9383021",
                        SquadId = "9383021",
                        MemberId = "00393"
                    },

                    new SquadMember
                    {
                        SquadMemberId = "00001-9383021",
                        SquadId = "9383021",
                        MemberId = "00001"
                    },

                    new SquadMember
                    {
                        SquadMemberId = "00002-9383021",
                        SquadId = "9383021",
                        MemberId = "00002",
                    },

                    new SquadMember
                    {
                        SquadMemberId = "00003-9383021",
                        SquadId = "9383021",
                        MemberId = "00003",
                    },

                    new SquadMember
                    {
                        SquadMemberId = "00004-9383021",
                        SquadId = "9383021",
                        MemberId = "00004",
                    },

                    new SquadMember
                    {
                        SquadMemberId = "03930-1919073",
                        SquadId = "1919073",
                        MemberId = "03930",
                    },

                    new SquadMember
                    {
                        SquadMemberId = "01002-1919073",
                        SquadId = "1919073",
                        MemberId = "01002",
                    },

                    new SquadMember
                    {
                        SquadMemberId = "29390-1919073",
                        SquadId = "1919073",
                        MemberId = "29390",
                    },

                    new SquadMember
                    {
                        SquadMemberId = "29312-1919073",
                        SquadId = "1919073",
                        MemberId = "29312",
                    },

                    new SquadMember
                    {
                        SquadMemberId = "28199-1919073",
                        SquadId = "1919073",
                        MemberId = "28199",
                    }

                    );
               
                context.SaveChanges();
            }
        }
    }
}
