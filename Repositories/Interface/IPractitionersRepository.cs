using CIPMApplication2.Models;

namespace CIPMApplication2.Repositories.Interface;

public interface IPractitionersRepository
{
    Task<IEnumerable<Practitioners>> GetAllPractitionerAsync();
    Task<Practitioners> GetPractitionerByIdAsync(int id);
    Task<Practitioners> CreatePractitioner(Students model);
    Task<Students> UpdatePractitionerAsync(int id, Students model);

    Task<IAsyncResult> DeletePractitionerByIdAsync(int id);
}
