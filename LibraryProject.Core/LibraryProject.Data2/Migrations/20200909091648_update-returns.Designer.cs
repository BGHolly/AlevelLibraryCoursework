// <auto-generated />
using System;
using LibraryProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryProject.Data2.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20200909091648_update-returns")]
    partial class Updatereturns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryProject.Data.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookBarcode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.HasIndex("BookBarcode");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("LibraryProject.Data.Book", b =>
                {
                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Barcode");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryProject.Data.ReturnsLog", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookBarcode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateDue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Returned")
                        .HasColumnType("bit");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LogId");

                    b.HasIndex("BookBarcode");

                    b.HasIndex("UserEmail");

                    b.ToTable("Returns");
                });

            modelBuilder.Entity("LibraryProject.Data.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Email");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LibraryProject.Data.Author", b =>
                {
                    b.HasOne("LibraryProject.Data.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookBarcode");
                });

            modelBuilder.Entity("LibraryProject.Data.ReturnsLog", b =>
                {
                    b.HasOne("LibraryProject.Data.Book", "Book")
                        .WithMany("ReturnsLogs")
                        .HasForeignKey("BookBarcode");

                    b.HasOne("LibraryProject.Data.User", "User")
                        .WithMany("ReturnsLogs")
                        .HasForeignKey("UserEmail");
                });
#pragma warning restore 612, 618
        }
    }
}
