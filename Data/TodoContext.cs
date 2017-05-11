using Microsoft.EntityFrameworkCore;
using WebAPIApplication.Model.Entities;

namespace WebAPIApplication.Data
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().ToTable("TodoItems");
        }
    }
}