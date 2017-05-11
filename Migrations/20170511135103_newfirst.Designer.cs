using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAPIApplication.Data;

namespace WebAPIApplication.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20170511135103_newfirst")]
    partial class newfirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("WebAPIApplication.Model.Entities.TodoItem", b =>
                {
                    b.Property<int>("TodoItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Task");

                    b.HasKey("TodoItemID");

                    b.ToTable("TodoItems");
                });
        }
    }
}
