using Microsoft.AspNetCore.Mvc;
using Student.Api.Data.Models;
using Student.Api.Models.Students;
using Student.Api.Service;
using System.Threading;
using System.Threading.Tasks;

namespace Student.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int page = 0, CancellationToken ct = default)
        {
            var students = await _studentService.GetAllAsync(page, ct);
            return Ok(students);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id, CancellationToken ct = default)
        {
            var student = await _studentService.GetAsync(id, ct);
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStudentDto student, CancellationToken ct = default)
        {
            var result = await _studentService.CreateAsync(student, ct);
            return result ? Ok("Student created successfully") : BadRequest("Failed to create student");
        }

        [HttpPut()]
        public async Task<IActionResult> Update( [FromBody] UpdateStudentDto student, CancellationToken ct = default)
        {

            var result = await _studentService.UpdateAsync(student, ct);
            return result ? Ok("Student updated successfully") : NotFound("Student not found");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct = default)
        {
            var result = await _studentService.DeleteAsync(id, ct);
            return result ? Ok("Student deleted successfully") : NotFound("Student not found");
        }
    }
}
