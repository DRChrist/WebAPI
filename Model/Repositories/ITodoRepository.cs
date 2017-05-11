using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApplication.Model.Entities;

namespace WebAPIApplication.Model.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> getAll();

        TodoItem Get(int id);

        void Delete(int id);

        void Update(TodoItem todoItem);

        void Save(TodoItem todoItem);
    }
}
