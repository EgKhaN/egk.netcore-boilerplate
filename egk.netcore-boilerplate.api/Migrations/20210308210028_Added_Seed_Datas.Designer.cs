﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using egk.netcore_boilerplate.api.Data;

namespace egk.netcore_boilerplate.api.Migrations
{
    [DbContext(typeof(TaskSystemContext))]
    [Migration("20210308210028_Added_Seed_Datas")]
    partial class Added_Seed_Datas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 838, DateTimeKind.Utc).AddTicks(6694),
                            Name = "Task System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 838, DateTimeKind.Utc).AddTicks(7011),
                            Name = "Budget System"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 838, DateTimeKind.Utc).AddTicks(7316),
                            Name = "Boilerplate"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 838, DateTimeKind.Utc).AddTicks(7619),
                            Name = "Scheduler"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 838, DateTimeKind.Utc).AddTicks(7832),
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 838, DateTimeKind.Utc).AddTicks(8036),
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

                    b.HasIndex("StatusId");

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
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 841, DateTimeKind.Utc).AddTicks(8761),
                            Name = "ToDo"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 841, DateTimeKind.Utc).AddTicks(8889),
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 841, DateTimeKind.Utc).AddTicks(9117),
                            Name = "Review"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 841, DateTimeKind.Utc).AddTicks(9280),
                            Name = "QA"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "EgK",
                            CreatedDate = new DateTime(2021, 3, 8, 21, 0, 28, 841, DateTimeKind.Utc).AddTicks(9473),
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
