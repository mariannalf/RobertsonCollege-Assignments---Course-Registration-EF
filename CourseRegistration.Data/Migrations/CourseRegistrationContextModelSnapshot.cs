﻿// <auto-generated />
using CourseRegistration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourseRegistration.Data.Migrations
{
    [DbContext(typeof(CourseRegistrationContext))]
    partial class CourseRegistrationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.26");

            modelBuilder.Entity("CourseRegistration.Data.Domain.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseNumber = 101,
                            Description = "Basic Math",
                            Name = "Math"
                        },
                        new
                        {
                            Id = 2,
                            CourseNumber = 102,
                            Description = "Basic Science",
                            Name = "Science"
                        },
                        new
                        {
                            Id = 3,
                            CourseNumber = 103,
                            Description = "Basic History",
                            Name = "History"
                        },
                        new
                        {
                            Id = 4,
                            CourseNumber = 104,
                            Description = "Basic English",
                            Name = "English"
                        },
                        new
                        {
                            Id = 5,
                            CourseNumber = 105,
                            Description = "Basic Art",
                            Name = "Art"
                        });
                });

            modelBuilder.Entity("CourseRegistration.Data.Domain.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            Email = "michael.johnson@example.com",
                            FirstName = "Michael",
                            LastName = "Johnson"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 4,
                            Email = "emily.brown@example.com",
                            FirstName = "Emily",
                            LastName = "Brown"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 5,
                            Email = "david.wilson@example.com",
                            FirstName = "David",
                            LastName = "Wilson"
                        });
                });

            modelBuilder.Entity("CourseRegistration.Data.Domain.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Phone = "1234567890"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Phone = "9876543210"
                        },
                        new
                        {
                            Id = 3,
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Phone = "5555555555"
                        },
                        new
                        {
                            Id = 4,
                            Email = "bob.williams@example.com",
                            FirstName = "Bob",
                            LastName = "Williams",
                            Phone = "6666666666"
                        },
                        new
                        {
                            Id = 5,
                            Email = "emily.brown@example.com",
                            FirstName = "Emily",
                            LastName = "Brown",
                            Phone = "7777777777"
                        },
                        new
                        {
                            Id = 6,
                            Email = "michael.jones@example.com",
                            FirstName = "Michael",
                            LastName = "Jones",
                            Phone = "8888888888"
                        },
                        new
                        {
                            Id = 7,
                            Email = "olivia.taylor@example.com",
                            FirstName = "Olivia",
                            LastName = "Taylor",
                            Phone = "9999999999"
                        },
                        new
                        {
                            Id = 8,
                            Email = "william.clark@example.com",
                            FirstName = "William",
                            LastName = "Clark",
                            Phone = "1111111111"
                        },
                        new
                        {
                            Id = 9,
                            Email = "sophia.lewis@example.com",
                            FirstName = "Sophia",
                            LastName = "Lewis",
                            Phone = "2222222222"
                        },
                        new
                        {
                            Id = 10,
                            Email = "james.hall@example.com",
                            FirstName = "James",
                            LastName = "Hall",
                            Phone = "3333333333"
                        },
                        new
                        {
                            Id = 11,
                            Email = "ava.young@example.com",
                            FirstName = "Ava",
                            LastName = "Young",
                            Phone = "4444444444"
                        },
                        new
                        {
                            Id = 12,
                            Email = "benjamin.lee@example.com",
                            FirstName = "Benjamin",
                            LastName = "Lee",
                            Phone = "5555555555"
                        },
                        new
                        {
                            Id = 13,
                            Email = "mia.walker@example.com",
                            FirstName = "Mia",
                            LastName = "Walker",
                            Phone = "6666666666"
                        },
                        new
                        {
                            Id = 14,
                            Email = "ethan.hall@example.com",
                            FirstName = "Ethan",
                            LastName = "Hall",
                            Phone = "7777777777"
                        },
                        new
                        {
                            Id = 15,
                            Email = "isabella.gonzalez@example.com",
                            FirstName = "Isabella",
                            LastName = "Gonzalez",
                            Phone = "8888888888"
                        },
                        new
                        {
                            Id = 16,
                            Email = "alexander.harris@example.com",
                            FirstName = "Alexander",
                            LastName = "Harris",
                            Phone = "9999999999"
                        },
                        new
                        {
                            Id = 17,
                            Email = "charlotte.king@example.com",
                            FirstName = "Charlotte",
                            LastName = "King",
                            Phone = "1111111111"
                        },
                        new
                        {
                            Id = 18,
                            Email = "daniel.wright@example.com",
                            FirstName = "Daniel",
                            LastName = "Wright",
                            Phone = "2222222222"
                        },
                        new
                        {
                            Id = 19,
                            Email = "scarlett.lopez@example.com",
                            FirstName = "Scarlett",
                            LastName = "Lopez",
                            Phone = "3333333333"
                        },
                        new
                        {
                            Id = 20,
                            Email = "henry.scott@example.com",
                            FirstName = "Henry",
                            LastName = "Scott",
                            Phone = "4444444444"
                        });
                });

            modelBuilder.Entity("StudentCourses", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 3
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 9
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 10
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 11
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 19
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 20
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 7
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 10
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 14
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 15
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 19
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 20
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 9
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 10
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 11
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 5
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 11
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 12
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 17
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 19
                        },
                        new
                        {
                            CourseId = 5,
                            StudentId = 20
                        });
                });

            modelBuilder.Entity("CourseRegistration.Data.Domain.Instructor", b =>
                {
                    b.HasOne("CourseRegistration.Data.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentCourses", b =>
                {
                    b.HasOne("CourseRegistration.Data.Domain.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegistration.Data.Domain.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
