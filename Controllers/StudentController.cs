using CIPMApplication2.Models;
using CIPMApplication2.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CIPMApplication2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{

    private readonly IStudentRepository _studentRepo;

    public StudentController(IStudentRepository studentRepo)
    {
        _studentRepo = studentRepo;
    }



    [HttpGet]
    public async Task<IEnumerable<Students>> GetAllStudentAsync()
    {
        var students = await _studentRepo.GetAllStudentAsync();
        return (IEnumerable<Students>)students;
    }

    
    [HttpGet("{id}")]
    public async Task<Students> GetStudentByIdAsync(int id)
    {
        var student = await _studentRepo.GetStudentByIdAsync(id);

        return student;
    }

    // POST api/<StudentController>
    [HttpPost]
    public async Task<Students> CreateStudentAsync([FromBody] Students model)
    {
        var student = await _studentRepo.CreateStudentAsync(model);
        return student;

    }

    
    [HttpPut("{id}")]
    public async Task<Students> UpdateStudentAsync([FromRoute] int id,  Students model)
    {
        var student = await _studentRepo.UpdateStudentAsync(id, model);

        return student;
    }

    
    [HttpDelete("{id}")]
    public async Task<IAsyncResult> DeleteStudentAsync(int id)
    {
        var student = await _studentRepo.DeleteStudentAsync(id);


        return student;
    }
}
