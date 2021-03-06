﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2bPrecise.Data;

namespace _2bPrecise.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_2bPrecise.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("LastName");

                    b.Property<int>("ManagerId");

                    b.Property<int>("Position");

                    b.HasKey("Id");

                    b.ToTable("EmployeesDb");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "The",
                            ImgUrl = "https://4.bp.blogspot.com/-tWGJ-aN1PxE/WNoH4DOOYNI/AAAAAAAAVcc/7B9s7OCcDRoSI5xugYKdz2sbxKFZQRCvQCPcB/s1600/Season%2B4%2Bpromo%2B5a.jpg",
                            LastName = "Doctor",
                            ManagerId = 0,
                            Position = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Sherlock",
                            ImgUrl = "https://www.fjackets.com/product_images/a/723/Benedict_Cumberbatch_Sherlock_Coat__78001_zoom.jpg",
                            LastName = "Holmes",
                            ManagerId = 1,
                            Position = 1
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "John",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/John_Oliver_November_2016.jpg/220px-John_Oliver_November_2016.jpg",
                            LastName = "Oliver",
                            ManagerId = 1,
                            Position = 1
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Matt",
                            ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGX06TZQG/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                            LastName = "Damon",
                            ManagerId = 2,
                            Position = 0
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Chris",
                            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSlLhjtiYwT4jd3tWyuFS6Rfp7u0rTKEw8s10VXNq7gXYkxkG_s",
                            LastName = "Pratt",
                            ManagerId = 3,
                            Position = 0
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Will",
                            ImgUrl = "http://cdn01.cdn.justjared.com/wp-content/uploads/headlines/2011/12/men-in-black-3.jpg",
                            LastName = "Smith",
                            ManagerId = 3,
                            Position = 0
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Forrest",
                            ImgUrl = "https://ksassets.timeincuk.net/wp/uploads/sites/55/2019/03/forrest-920x584.png",
                            LastName = "Gump",
                            ManagerId = 3,
                            Position = 0
                        });
                });

            modelBuilder.Entity("_2bPrecise.Models.ReportItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("IssuedDate");

                    b.Property<int>("ManagerId");

                    b.Property<string>("ReportText");

                    b.HasKey("Id");

                    b.ToTable("ReportItemsDb");

                    b.HasData(
                        new
                        {
                            Id = 8,
                            EmployeeId = 7,
                            IssuedDate = new DateTime(2019, 4, 24, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            ManagerId = 3,
                            ReportText = "Report 1 text"
                        },
                        new
                        {
                            Id = 9,
                            EmployeeId = 7,
                            IssuedDate = new DateTime(2019, 5, 1, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            ManagerId = 3,
                            ReportText = "Report 2 text"
                        },
                        new
                        {
                            Id = 10,
                            EmployeeId = 6,
                            IssuedDate = new DateTime(2019, 5, 7, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            ManagerId = 3,
                            ReportText = "Report 3 text"
                        },
                        new
                        {
                            Id = 11,
                            EmployeeId = 4,
                            IssuedDate = new DateTime(2019, 5, 16, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            ManagerId = 2,
                            ReportText = "Report 4 text"
                        },
                        new
                        {
                            Id = 12,
                            EmployeeId = 3,
                            IssuedDate = new DateTime(2019, 5, 29, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            ManagerId = 1,
                            ReportText = "Report 5 text"
                        },
                        new
                        {
                            Id = 13,
                            EmployeeId = 2,
                            IssuedDate = new DateTime(2019, 6, 2, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            ManagerId = 1,
                            ReportText = "Report 6 text"
                        });
                });

            modelBuilder.Entity("_2bPrecise.Models.TaskItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssignedDate");

                    b.Property<DateTime>("DueDate");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("ManagerId");

                    b.Property<string>("TaskText");

                    b.HasKey("Id");

                    b.ToTable("TaskItemsDb");

                    b.HasData(
                        new
                        {
                            Id = 14,
                            AssignedDate = new DateTime(2019, 5, 24, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            DueDate = new DateTime(2019, 5, 29, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            EmployeeId = 7,
                            ManagerId = 3,
                            TaskText = "Task 1 text"
                        },
                        new
                        {
                            Id = 15,
                            AssignedDate = new DateTime(2019, 5, 25, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            DueDate = new DateTime(2019, 6, 2, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            EmployeeId = 3,
                            ManagerId = 2,
                            TaskText = "Task 2 text, changed Manager"
                        },
                        new
                        {
                            Id = 16,
                            AssignedDate = new DateTime(2019, 5, 25, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            DueDate = new DateTime(2019, 5, 29, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            EmployeeId = 6,
                            ManagerId = 3,
                            TaskText = "Task 3 text"
                        },
                        new
                        {
                            Id = 17,
                            AssignedDate = new DateTime(2019, 5, 27, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            DueDate = new DateTime(2019, 6, 1, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            EmployeeId = 5,
                            ManagerId = 3,
                            TaskText = "Task 4 text"
                        },
                        new
                        {
                            Id = 18,
                            AssignedDate = new DateTime(2019, 5, 30, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            DueDate = new DateTime(2019, 6, 5, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            EmployeeId = 4,
                            ManagerId = 2,
                            TaskText = "Task 5 text"
                        },
                        new
                        {
                            Id = 19,
                            AssignedDate = new DateTime(2019, 6, 6, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            DueDate = new DateTime(2019, 6, 10, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            EmployeeId = 4,
                            ManagerId = 2,
                            TaskText = "Task 6 text"
                        },
                        new
                        {
                            Id = 20,
                            AssignedDate = new DateTime(2019, 6, 10, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            DueDate = new DateTime(2019, 6, 18, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            EmployeeId = 2,
                            ManagerId = 1,
                            TaskText = "Task 7 text"
                        },
                        new
                        {
                            Id = 21,
                            AssignedDate = new DateTime(2019, 6, 11, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            DueDate = new DateTime(2019, 6, 16, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305),
                            EmployeeId = 3,
                            ManagerId = 1,
                            TaskText = "Task 8 text"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
