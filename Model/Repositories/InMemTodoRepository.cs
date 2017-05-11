using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIApplication.Data;
using WebAPIApplication.Model.Entities;

namespace WebAPIApplication.Model.Repositories
{
    public class InMemTodoRepository : ITodoRepository
    {
        private TodoContext _db;

        private DbSet<TodoItem> _todoItems;
        public InMemTodoRepository(TodoContext db)
        {
            _db = db;
            _todoItems = db.TodoItems;
        }

        public void Delete(int id)
        {
            var item = _todoItems.Find(id);
            _db.TodoItems.Remove(item);
            _db.SaveChanges();
        }

        public TodoItem Get(int id)
        {
            return _todoItems.Find(id);
        }

        public IEnumerable<TodoItem> getAll()
        {
            return _todoItems;
        }

        public void Save(TodoItem todoItem)
        {
            _db.Add(todoItem);
            _db.SaveChanges();
        }

        public void Update(TodoItem todoItem)
        {
            _db.Update(todoItem);
            _db.SaveChanges();
        }
    }
}
