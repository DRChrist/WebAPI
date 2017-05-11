using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAPIApplication.Model.Entities;

namespace WebAPIApplication.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.TodoItems.Any())
            {
                return;   // DB has been seeded
            }

            var todoItems = new TodoItem[]
            {
            new TodoItem{TodoItemID=1,Task="Be Free",IsComplete=false},
            new TodoItem{TodoItemID=2,Task="Be Alone",IsComplete=false},
            new TodoItem{TodoItemID=3,Task="Find Time",IsComplete=false},
            new TodoItem{TodoItemID=4,Task="Stay Closed",IsComplete=false},
            new TodoItem{TodoItemID=5,Task="Know All",IsComplete=false},
            new TodoItem{TodoItemID=6,Task="Run Up",IsComplete=false},
            new TodoItem{TodoItemID=7,Task="Stand In",IsComplete=false},
            new TodoItem{TodoItemID=8,Task="Sit Something",IsComplete=false},
            new TodoItem{TodoItemID=9,Task="Realize it",IsComplete=false},
             };
            foreach (TodoItem t in todoItems)
            {
                context.TodoItems.Add(t);
            }
            context.SaveChanges();

           
        }
    }
}