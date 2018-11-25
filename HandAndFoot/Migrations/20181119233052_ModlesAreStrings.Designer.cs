﻿// <auto-generated />
using HandAndFoot.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HandAndFoot.Migrations
{
    [DbContext(typeof(HandAndFootDbContext))]
    [Migration("20181119233052_ModlesAreStrings")]
    partial class ModlesAreStrings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HandAndFoot.Models.GameTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiscardPile");

                    b.Property<string>("GameDeck");

                    b.Property<string>("GameTableID");

                    b.Property<string>("PlayersList");

                    b.HasKey("ID");

                    b.ToTable("GameTables");
                });

            modelBuilder.Entity("HandAndFoot.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Books");

                    b.Property<string>("Foot");

                    b.Property<string>("GameTableID");

                    b.Property<string>("Hand");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
