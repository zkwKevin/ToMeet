﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ToMeet.Models;

namespace ToMeet.Migrations
{
    [DbContext(typeof(ToMeetContext))]
    [Migration("20180616053503_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("ToMeet.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<int>("Number");

                    b.Property<string>("Publisher");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Event");
                });
#pragma warning restore 612, 618
        }
    }
}
