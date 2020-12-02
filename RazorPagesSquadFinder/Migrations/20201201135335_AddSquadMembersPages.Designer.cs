﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesSquadFinder.Data;

namespace RazorPagesSquadFinder.Migrations
{
    [DbContext(typeof(RazorPagesSquadFinderContext))]
    [Migration("20201201135335_AddSquadMembersPages")]
    partial class AddSquadMembersPages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesSquadFinder.Models.Member", b =>
                {
                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("RazorPagesSquadFinder.Models.Squad", b =>
                {
                    b.Property<string>("SquadId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NoOfSquadMembers")
                        .HasColumnType("int");

                    b.Property<string>("Sport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SquadLeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SquadId");

                    b.ToTable("Squad");
                });

            modelBuilder.Entity("RazorPagesSquadFinder.Models.SquadMember", b =>
                {
                    b.Property<string>("SquadMemberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SquadId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SquadMemberId");

                    b.HasIndex("MemberId");

                    b.HasIndex("SquadId");

                    b.ToTable("SquadMember");
                });

            modelBuilder.Entity("RazorPagesSquadFinder.Models.SquadMember", b =>
                {
                    b.HasOne("RazorPagesSquadFinder.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId");

                    b.HasOne("RazorPagesSquadFinder.Models.Squad", "Squad")
                        .WithMany()
                        .HasForeignKey("SquadId");
                });
#pragma warning restore 612, 618
        }
    }
}
