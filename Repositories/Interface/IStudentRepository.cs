using CIPMApplication2.Models;

namespace CIPMApplication2.Repositories.Interface;

public interface IStudentRepository
{
    Task<IEnumerable<Students>> GetAllStudentAsync();
    Task<Students> GetStudentByIdAsync(int id);
    Task<Students> CreateStudentAsync(Students model);
    Task<Students> UpdateStudentAsync(int id, Students model);

    Task<IAsyncResult> DeleteStudentAsync(int id);

}
