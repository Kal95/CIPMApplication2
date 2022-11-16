using CIPMApplication2.Data;
using CIPMApplication2.Models;
using CIPMApplication2.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CIPMApplication2.Repositories.Repository;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Students> CreateStudentAsync(Students model)
    {
        await _context.Students.AddAsync(model);
        await _context.SaveChangesAsync();
        return model; 
    }

    public async Task<IAsyncResult> DeleteStudentAsync(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return Task.FromResult($"Student with id {id} is Successfully deleted");

        }
        else
        {
            return Task.FromResult($"Student with id{id} not found");
        }
    }

    public async Task<IEnumerable<Students>> GetAllStudentAsync()
    {
        var students = await _context.Students.ToListAsync();
        return students;
    }

    public async Task<Students> GetStudentByIdAsync(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student != null)
        {
            return student;
        }
        else
        {
            return new Students();
        }
    }

    public async Task<Students> UpdateStudentAsync(int id, Students model)
    {
        
            var student = await _context.Students.FindAsync(id);

            if(student != null)
            {
                //_context.Entry(student).State = EntityState.Modified;
                
                student.Address = model.Address;
                student.City = model.City;  
                student.Created = model.Created; 
                student.Email = model.Email;
                student.FrstName = model.FrstName;
                student.LastName = model.LastName;
                student.Phone = model.Phone;
                student.Discipline = model.Discipline;
                student.Institution = model.Institution;
                student.Gender = model.Gender;
                student.ExpectedYearOfGraduation = model.ExpectedYearOfGraduation;
                student.Title = model.Title;
                student.Status = model.Status;

                
                _context.Students.Update(student);
                await _context.SaveChangesAsync();
                return student;

            }
            
        
        return new Students();
    }
}
