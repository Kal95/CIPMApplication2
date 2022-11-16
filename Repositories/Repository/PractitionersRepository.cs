using CIPMApplication2.Models;
using CIPMApplication2.Repositories.Interface;

namespace CIPMApplication2.Repositories.Repository;

public class PractitionersRepository : IPractitionersRepository
{
    public Task<Students> CreatePractitioner(Students model)
    {
        throw new NotImplementedException();
    }

    public Task<IAsyncResult> DeletePractitionerByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Students>> GetAllPractitionerAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Students> GetPractitionerByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Students> UpdatePractitionerAsync(int id, Students model)
    {
        throw new NotImplementedException();
    }

    Task<Practitioners> IPractitionersRepository.CreatePractitioner(Students model)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<Practitioners>> IPractitionersRepository.GetAllPractitionerAsync()
    {
        throw new NotImplementedException();
    }

    Task<Practitioners> IPractitionersRepository.GetPractitionerByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
