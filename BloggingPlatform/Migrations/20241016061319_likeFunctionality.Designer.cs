﻿// <auto-generated />
using System;
using BloggingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BloggingPlatform.Migrations
{
    [DbContext(typeof(BloggingPlatformContext))]
    [Migration("20241016061319_likeFunctionality")]
    partial class likeFunctionality
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Role")
                        .HasColumnType("tinyint");

                    b.HasKey("ID");

                    b.ToTable("Author", (string)null);
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.AuthorBlogLike", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<Guid>("BlogId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorId", "BlogId");

                    b.HasIndex("BlogId");

                    b.ToTable("AuthorBlogLike");
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Blog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Blog", (string)null);
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EntryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntryID");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Technology",
                            Slug = "technology"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Health",
                            Slug = "health"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Travel",
                            Slug = "travel"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Food",
                            Slug = "food"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fashion",
                            Slug = "fashion"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Lifestyle",
                            Slug = "lifestyle"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Business",
                            Slug = "business"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Education",
                            Slug = "education"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Entertainment",
                            Slug = "entertainment"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sports",
                            Slug = "sports"
                        });
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BlogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Comment", (string)null);
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Entry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.ToTable("Entry", (string)null);
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Option", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Option", (string)null);
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.AuthorBlogLike", b =>
                {
                    b.HasOne("BloggingPlatform.Models.Entity.Author", "Author")
                        .WithMany("LikedBlogs")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BloggingPlatform.Models.Entity.Blog", "Blog")
                        .WithMany("LikedByAuthors")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Blog", b =>
                {
                    b.HasOne("BloggingPlatform.Models.Entity.Author", "Author")
                        .WithMany("Blogs")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloggingPlatform.Models.Entity.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Category", b =>
                {
                    b.HasOne("BloggingPlatform.Models.Entity.Entry", null)
                        .WithMany("Categories")
                        .HasForeignKey("EntryID");
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Comment", b =>
                {
                    b.HasOne("BloggingPlatform.Models.Entity.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Entry", b =>
                {
                    b.HasOne("BloggingPlatform.Models.Entity.Author", "Author")
                        .WithMany("Entries")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Author", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Entries");

                    b.Navigation("LikedBlogs");
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Blog", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("LikedByAuthors");
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("BloggingPlatform.Models.Entity.Entry", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
