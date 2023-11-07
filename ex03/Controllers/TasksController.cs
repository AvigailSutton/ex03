using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ex02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService taskService;

        public TasksController(ITaskService taskService)
        {
            this.taskService = taskService;  
        }

        // GET: api/<ValuesController>
        //[HttpGet]
        //public IEnumerable<bool> Get(string title, string description, DateTime time, Preference preference)
        //{
        //    bool b=
        //    return b;
        //}

        //// GET api/<ValuesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ValuesController>
        [HttpPost]
        public Tasks Post(string title, string description, DateTime time, Preference preference)
        {
            return taskService.createTask(title, description, time, preference);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public Tasks Put(int id,  string title, string description, DateTime time, Preference preference)//[FromBody]
        {
            return taskService.updateTask(id,title, description, time, preference);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return taskService.deleteTask(id);
        }
    }
}
