using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIApplication.Model.Entities;
using WebAPIApplication.Model.Repositories;

namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        private ITodoRepository _todoRepository;

        public TodosController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var todos = _todoRepository.getAll();
            return new OkObjectResult(todos);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(_todoRepository.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]TodoItem item)
        {
            _todoRepository.Save(item);
            return Created("api/todos/" + item.TodoItemID, "{\"msg\" : \"Item Created\"}");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            // _todoRepository.Update(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _todoRepository.Delete(id);
            return NoContent();
        }
    }
}
