﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using egk.netcore_boilerplate.api.Data;

namespace egk.netcore_boilerplate.api.Migrations
{
    [DbContext(typeof(TaskSystemContext))]
    partial class TaskSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("egk.netcore_boilerplate.api.Data.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 213, DateTimeKind.Utc).AddTicks(5487),
                            Name = "Task System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 213, DateTimeKind.Utc).AddTicks(5680),
                            Name = "Budget System"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 213, DateTimeKind.Utc).AddTicks(5786),
                            Name = "Boilerplate"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 213, DateTimeKind.Utc).AddTicks(5882),
                            Name = "Scheduler"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 213, DateTimeKind.Utc).AddTicks(5981),
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 213, DateTimeKind.Utc).AddTicks(6078),
                            Name = "Personal Asistant"
                        });
                });

            modelBuilder.Entity("egk.netcore_boilerplate.api.Data.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BackLogId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDone")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StatusId")
                        .IsUnique();

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("egk.netcore_boilerplate.api.Data.Models.TaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("TaskStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 213, DateTimeKind.Utc).AddTicks(9758),
                            Name = "ToDo"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 213, DateTimeKind.Utc).AddTicks(9869),
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 214, DateTimeKind.Utc).AddTicks(3),
                            Name = "Review"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 214, DateTimeKind.Utc).AddTicks(97),
                            Name = "QA"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 5, 23, 20, 36, 2, 214, DateTimeKind.Utc).AddTicks(190),
                            Name = "Deployed"
                        });
                });

            modelBuilder.Entity("egk.netcore_boilerplate.api.Data.Models.Task", b =>
                {
                    b.HasOne("egk.netcore_boilerplate.api.Data.Models.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("egk.netcore_boilerplate.api.Data.Models.TaskStatus", "Status")
                        .WithOne("Task")
                        .HasForeignKey("egk.netcore_boilerplate.api.Data.Models.Task", "StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
