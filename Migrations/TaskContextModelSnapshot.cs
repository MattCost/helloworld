﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TaskApp2;
using TaskApp2.Models;

namespace TaskApp2.Migrations
{
    [DbContext(typeof(TaskContext))]
    partial class TaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("TaskApp2.Models.Task", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Complete");

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.Property<int>("RepeatFreq");

                    b.Property<DateTime>("ScheduleDay");

                    b.Property<int>("SelectedDay");

                    b.HasKey("ID");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("TaskApp2.Models.TaskInstance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Complete");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.Property<DateTime>("TaskDate");

                    b.Property<int>("TemplateID");

                    b.HasKey("ID");

                    b.ToTable("TaskList");
                });

            modelBuilder.Entity("TaskApp2.Models.TaskTemplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Desc");

                    b.Property<DateTime>("FirstDay");

                    b.Property<string>("Name");

                    b.Property<int>("RepeatFreq");

                    b.Property<int>("SelectedDay");

                    b.HasKey("ID");

                    b.ToTable("TaskTemplate");
                });
#pragma warning restore 612, 618
        }
    }
}
