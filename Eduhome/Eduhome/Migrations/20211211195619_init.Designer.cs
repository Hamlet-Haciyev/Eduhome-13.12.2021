﻿// <auto-generated />
using System;
using Eduhome.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Eduhome.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211211195619_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Eduhome.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Page")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("Eduhome.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Eduhome.Models.CourseToCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Category_Id");

                    b.HasIndex("Course_Id");

                    b.ToTable("CourseToCategories");
                });

            modelBuilder.Entity("Eduhome.Models.CourseToTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Tag_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Course_Id");

                    b.HasIndex("Tag_Id");

                    b.ToTable("CourseToTags");
                });

            modelBuilder.Entity("Eduhome.Models.Course_About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Course_Id");

                    b.ToTable("Course_Abouts");
                });

            modelBuilder.Entity("Eduhome.Models.Course_Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Course_Categories");
                });

            modelBuilder.Entity("Eduhome.Models.Course_Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Comment_Id")
                        .HasColumnType("int");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Message")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Parent_CommentId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Course_Id");

                    b.HasIndex("Parent_CommentId");

                    b.ToTable("Course_Comments");
                });

            modelBuilder.Entity("Eduhome.Models.Course_Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Course_Tags");
                });

            modelBuilder.Entity("Eduhome.Models.Features", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assesments")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("ClassDuration")
                        .HasColumnType("datetime2");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Course_Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Language")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SkillLevel")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("StartsDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Student_Count")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Course_Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Eduhome.Models.Hobbie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("Eduhome.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Email_1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email_2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Logo")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Phone_1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Eduhome.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<byte>("Percent")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Eduhome.Models.Social", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Link")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Socials");
                });

            modelBuilder.Entity("Eduhome.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Degree")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Experience")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Faculty")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Mail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Position")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Skype")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Eduhome.Models.TeacherToSocial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Social_Id")
                        .HasColumnType("int");

                    b.Property<int>("Teacher_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Teacher_SocialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Social_Id");

                    b.HasIndex("Teacher_Id");

                    b.HasIndex("Teacher_SocialId");

                    b.ToTable("TeacherToSocials");
                });

            modelBuilder.Entity("Eduhome.Models.Teacher_Hobbie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Hobbie_Id")
                        .HasColumnType("int");

                    b.Property<int>("Teacher_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Hobbie_Id");

                    b.HasIndex("Teacher_Id");

                    b.ToTable("Teacher_Hobbies");
                });

            modelBuilder.Entity("Eduhome.Models.Teacher_Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Skill_Id")
                        .HasColumnType("int");

                    b.Property<int>("Teacher_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Skill_Id");

                    b.HasIndex("Teacher_Id");

                    b.ToTable("Teacher_Skills");
                });

            modelBuilder.Entity("Eduhome.Models.Teacher_Social", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Link")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Teacher_Socials");
                });

            modelBuilder.Entity("Eduhome.Models.CourseToCategory", b =>
                {
                    b.HasOne("Eduhome.Models.Course_Categories", "Course_Categories")
                        .WithMany("CourseToCategory")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eduhome.Models.Course", "Course")
                        .WithMany("CourseToCategory")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Course_Categories");
                });

            modelBuilder.Entity("Eduhome.Models.CourseToTag", b =>
                {
                    b.HasOne("Eduhome.Models.Course", "Course")
                        .WithMany("CourseToTag")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eduhome.Models.Course_Tag", "Course_Tag")
                        .WithMany("CourseToTag")
                        .HasForeignKey("Tag_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Course_Tag");
                });

            modelBuilder.Entity("Eduhome.Models.Course_About", b =>
                {
                    b.HasOne("Eduhome.Models.Course", "Course")
                        .WithMany("Course_About")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Eduhome.Models.Course_Comment", b =>
                {
                    b.HasOne("Eduhome.Models.Course", "Course")
                        .WithMany("Course_Comment")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eduhome.Models.Course_Comment", "Parent_Comment")
                        .WithMany()
                        .HasForeignKey("Parent_CommentId");

                    b.Navigation("Course");

                    b.Navigation("Parent_Comment");
                });

            modelBuilder.Entity("Eduhome.Models.Features", b =>
                {
                    b.HasOne("Eduhome.Models.Course", "Course")
                        .WithMany("Features")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Eduhome.Models.TeacherToSocial", b =>
                {
                    b.HasOne("Eduhome.Models.Social", "Social")
                        .WithMany("TeacherToSocials")
                        .HasForeignKey("Social_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eduhome.Models.Teacher", "Teacher")
                        .WithMany("TeacherToSocials")
                        .HasForeignKey("Teacher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eduhome.Models.Teacher_Social", null)
                        .WithMany("TeacherToSocials")
                        .HasForeignKey("Teacher_SocialId");

                    b.Navigation("Social");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Eduhome.Models.Teacher_Hobbie", b =>
                {
                    b.HasOne("Eduhome.Models.Hobbie", "Hobbie")
                        .WithMany("Teacher_Hobbies")
                        .HasForeignKey("Hobbie_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eduhome.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Hobbies")
                        .HasForeignKey("Teacher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hobbie");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Eduhome.Models.Teacher_Skill", b =>
                {
                    b.HasOne("Eduhome.Models.Skill", "Skill")
                        .WithMany("Teacher_Skills")
                        .HasForeignKey("Skill_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eduhome.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Skills")
                        .HasForeignKey("Teacher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Eduhome.Models.Course", b =>
                {
                    b.Navigation("Course_About");

                    b.Navigation("Course_Comment");

                    b.Navigation("CourseToCategory");

                    b.Navigation("CourseToTag");

                    b.Navigation("Features");
                });

            modelBuilder.Entity("Eduhome.Models.Course_Categories", b =>
                {
                    b.Navigation("CourseToCategory");
                });

            modelBuilder.Entity("Eduhome.Models.Course_Tag", b =>
                {
                    b.Navigation("CourseToTag");
                });

            modelBuilder.Entity("Eduhome.Models.Hobbie", b =>
                {
                    b.Navigation("Teacher_Hobbies");
                });

            modelBuilder.Entity("Eduhome.Models.Skill", b =>
                {
                    b.Navigation("Teacher_Skills");
                });

            modelBuilder.Entity("Eduhome.Models.Social", b =>
                {
                    b.Navigation("TeacherToSocials");
                });

            modelBuilder.Entity("Eduhome.Models.Teacher", b =>
                {
                    b.Navigation("Teacher_Hobbies");

                    b.Navigation("Teacher_Skills");

                    b.Navigation("TeacherToSocials");
                });

            modelBuilder.Entity("Eduhome.Models.Teacher_Social", b =>
                {
                    b.Navigation("TeacherToSocials");
                });
#pragma warning restore 612, 618
        }
    }
}