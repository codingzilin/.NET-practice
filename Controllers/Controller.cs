using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnet_practice.Data;
using dotnet_practice.Entities;
using dotnet_practice.Services;

namespace dotnet_practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        // private readonly TodoService _todoService;
        public TaskController()
        {
            // _todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetTodoItems()
        {
            // var todoItems = _todoService.GetTodoItems();
            return Ok("Hello World");
        }

        
    }
}