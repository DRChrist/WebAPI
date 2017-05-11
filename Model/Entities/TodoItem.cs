using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApplication.Model.Entities
{
    public class TodoItem
    {
        public int TodoItemID { get; set; }
        public string Task { get; set; }
        public Boolean IsComplete { get; set; }
    }
}
