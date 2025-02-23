using Microsoft.AspNetCore.Mvc;
using SchoolReinforcement.Entities;
using SchoolReinforcement.Interfaces.Service;

namespace SchoolReinforcement.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IService<Student> _service;

        public StudentController(IService<Student> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            Student student = _service.GetById(id);
            return Ok(student);
        }
    }
}
