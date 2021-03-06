﻿// <auto-generated />
using System;
using EfLearning.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfLearning.Data.Migrations
{
    [DbContext(typeof(EfContext))]
    partial class EfContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfLearning.Core.Announcements.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description");

                    b.Property<int?>("MaterialId");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId")
                        .IsUnique()
                        .HasFilter("[MaterialId] IS NOT NULL");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("EfLearning.Core.Announcements.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnnouncementId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EfLearning.Core.Classrooms.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<byte>("ProgrammingType");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EfLearning.Core.Classrooms.GivenClassroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("GivenClassrooms");
                });

            modelBuilder.Entity("EfLearning.Core.Classrooms.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnnouncementId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime?>("Deadline");

                    b.Property<int>("GivenClassroomId");

                    b.Property<string>("Hint");

                    b.Property<int?>("MaterialScale");

                    b.Property<int>("MaterialType");

                    b.Property<string>("Question");

                    b.HasKey("Id");

                    b.HasIndex("GivenClassroomId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("EfLearning.Core.Classrooms.MaterialAnswer", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("MaterialId");

                    b.Property<string>("Answer");

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("Score");

                    b.HasKey("UserId", "MaterialId");

                    b.HasIndex("MaterialId");

                    b.ToTable("MaterialAnswers");
                });

            modelBuilder.Entity("EfLearning.Core.Classrooms.TakenClassroom", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("GivenClassroomId");

                    b.Property<DateTime>("CreationTime");

                    b.HasKey("UserId", "GivenClassroomId");

                    b.HasIndex("GivenClassroomId");

                    b.ToTable("TakenClassrooms");
                });

            modelBuilder.Entity("EfLearning.Core.Practices.DonePractice", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("GivenPracticeId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("TotalDonePractice");

                    b.HasKey("UserId", "GivenPracticeId");

                    b.HasIndex("GivenPracticeId");

                    b.ToTable("DonePractices");
                });

            modelBuilder.Entity("EfLearning.Core.Practices.GivenPractice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition");

                    b.Property<string>("Hint");

                    b.Property<int>("Level");

                    b.Property<byte>("ProgrammingType");

                    b.Property<string>("Question");

                    b.Property<string>("Solution");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("GivenPractices");
                });

            modelBuilder.Entity("EfLearning.Core.Users.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("EfLearning.Core.Users.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EfLearning.Core.Users.RefreshToken", b =>
                {
                    b.Property<string>("Token")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<bool>("Invalidated");

                    b.Property<string>("JwtId");

                    b.Property<bool>("Used");

                    b.Property<int?>("UserId");

                    b.HasKey("Token");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EfLearning.Core.Announcements.Announcement", b =>
                {
                    b.HasOne("EfLearning.Core.Classrooms.Material", "Material")
                        .WithOne("Announcement")
                        .HasForeignKey("EfLearning.Core.Announcements.Announcement", "MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfLearning.Core.Announcements.Comment", b =>
                {
                    b.HasOne("EfLearning.Core.Announcements.Announcement", "Announcement")
                        .WithMany("Comments")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfLearning.Core.Users.AppUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EfLearning.Core.Classrooms.GivenClassroom", b =>
                {
                    b.HasOne("EfLearning.Core.Classrooms.Course", "Course")
                        .WithMany("GivenClassrooms")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfLearning.Core.Users.AppUser", "User")
                        .WithMany("GivenClassrooms")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EfLearning.Core.Classrooms.Material", b =>
                {
                    b.HasOne("EfLearning.Core.Classrooms.GivenClassroom", "GivenClassroom")
                        .WithMany("Materials")
                        .HasForeignKey("GivenClassroomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfLearning.Core.Classrooms.MaterialAnswer", b =>
                {
                    b.HasOne("EfLearning.Core.Classrooms.Material", "Material")
                        .WithMany("MaterialAnswers")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfLearning.Core.Users.AppUser", "User")
                        .WithMany("MaterialAnswers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfLearning.Core.Classrooms.TakenClassroom", b =>
                {
                    b.HasOne("EfLearning.Core.Classrooms.GivenClassroom", "GivenClassroom")
                        .WithMany("TakenClassrooms")
                        .HasForeignKey("GivenClassroomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfLearning.Core.Users.AppUser", "User")
                        .WithMany("TakenClassrooms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfLearning.Core.Practices.DonePractice", b =>
                {
                    b.HasOne("EfLearning.Core.Practices.GivenPractice", "GivenPractice")
                        .WithMany("DonePractices")
                        .HasForeignKey("GivenPracticeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfLearning.Core.Users.AppUser", "User")
                        .WithMany("DonePractices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfLearning.Core.Users.RefreshToken", b =>
                {
                    b.HasOne("EfLearning.Core.Users.AppUser", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("EfLearning.Core.Users.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("EfLearning.Core.Users.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("EfLearning.Core.Users.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("EfLearning.Core.Users.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfLearning.Core.Users.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("EfLearning.Core.Users.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
