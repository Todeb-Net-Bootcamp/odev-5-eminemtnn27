﻿// <auto-generated />
using System;
using DataAccessLayer.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Models.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Models.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("bookPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("number_of_pages")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Models.Entities.BookAuthorPublish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int?>("ReaderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("ReaderId");

                    b.ToTable("BookAuthorPublishes");
                });

            modelBuilder.Entity("Models.Entities.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Models.Entities.Reader", b =>
                {
                    b.Property<int>("ReaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReaderId");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("Models.Entities.Book", b =>
                {
                    b.HasOne("Models.Entities.Publisher", "Publisher")
                        .WithMany("books")
                        .HasForeignKey("PublisherId");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Models.Entities.BookAuthorPublish", b =>
                {
                    b.HasOne("Models.Entities.Author", "Author")
                        .WithMany("bookAuthorPublishes")
                        .HasForeignKey("AuthorId");

                    b.HasOne("Models.Entities.Book", "Book")
                        .WithMany("bookAuthorPublishes")
                        .HasForeignKey("BookId");

                    b.HasOne("Models.Entities.Publisher", "Publisher")
                        .WithMany("bookAuthorPublishes")
                        .HasForeignKey("PublisherId");

                    b.HasOne("Models.Entities.Reader", "Reader")
                        .WithMany("bookAuthorPublishes")
                        .HasForeignKey("ReaderId");

                    b.Navigation("Author");

                    b.Navigation("Book");

                    b.Navigation("Publisher");

                    b.Navigation("Reader");
                });

            modelBuilder.Entity("Models.Entities.Author", b =>
                {
                    b.Navigation("bookAuthorPublishes");
                });

            modelBuilder.Entity("Models.Entities.Book", b =>
                {
                    b.Navigation("bookAuthorPublishes");
                });

            modelBuilder.Entity("Models.Entities.Publisher", b =>
                {
                    b.Navigation("bookAuthorPublishes");

                    b.Navigation("books");
                });

            modelBuilder.Entity("Models.Entities.Reader", b =>
                {
                    b.Navigation("bookAuthorPublishes");
                });
#pragma warning restore 612, 618
        }
    }
}
