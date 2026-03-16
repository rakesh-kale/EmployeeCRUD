using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPICRUD.Models;
using WEBAPICRUD.Repository.Interface;

namespace WEBAPICRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await _repo.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var emp = await _repo.GetById(id);
            if (emp == null) return NotFound();
            return Ok(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee emp)
        {
            var result = await _repo.Add(emp);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Employee emp)
        {
            var result = await _repo.Update(emp);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _repo.Delete(id);
            if (!result) return NotFound();
            return Ok();
        }

    }
}
