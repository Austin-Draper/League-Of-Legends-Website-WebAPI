﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegisterWebAPI.Models;

namespace RegisterWebAPI.Migrations.UniqueTags
{
    [DbContext(typeof(UniqueTagsContext))]
    [Migration("20201231222950_AddUniqueTagsContext")]
    partial class AddUniqueTagsContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RegisterWebAPI.Models.UniqueTags", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tag1")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag10")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag11")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag12")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag13")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag14")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag15")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag16")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag17")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag18")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag19")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag2")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag20")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag21")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag22")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag23")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag24")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag25")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag26")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag27")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag28")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag29")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag3")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag30")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag4")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag5")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag6")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag7")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag8")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tag9")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Email");

                    b.ToTable("UniqueTags");
                });
#pragma warning restore 612, 618
        }
    }
}
