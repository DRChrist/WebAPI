using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIApplication.Model.Entities;

namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        // GET api/values
        List<TodoItem> _todoList = new List<TodoItem>();
        [HttpGet]
        public IActionResult Get()
        {
            _todoList.Add(new TodoItem{TodoItemID = 1, Task = "First Task", IsComplete = false}); 
            return new OkObjectResult(_todoList);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}