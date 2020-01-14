using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Models;

namespace SwaggerDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult<TodoItems> Create(TodoItems item)
        {
            return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        }

        [HttpGet]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult Index()
        {
            return CreatedAtRoute("GetTodo", new TodoItems());
        }
    }
}