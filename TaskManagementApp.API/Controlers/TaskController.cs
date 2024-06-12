using Microsoft.AspNetCore.Mvc;
using TaskManagementApp.Application.Services;

namespace TaskManagementApp.API.Controlers
{
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskDto>>> GetTasks()
        {
            var tasks = await _taskService.GetTasksAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDto>> GetTask(int id)
        {
            var task = await _taskService.GetTaskAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask(TaskDto task)
        {
            await _taskService.CreateTaskAsync(Task);
            return CreatedAction(nameof(GetTask), new { id = task.Id}, task);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTask(TaskDto task)
        {
            var taskEntity = await _taskService.GetTasksAsync(id);

            if (taskEntity == null)
            {
                return BadRequest();
            }

            await _taskService.UpdateTaskAsync(taskEntity);
            return Ok(taskEntity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            await _taskService.DeleteAsync(id);
            return Ok();
        }
    }
}
