
using CandidateContactInfo.Models;

namespace CandidateContactInfo.Repositories
{
    public interface ICandidateRepository
    {
        Task<IEnumerable<Candidate>> GetAllCandidatesAsync();
        Task<Candidate> GetCandidateByIdAsync(int id);
        Task<Candidate> AddCandidateAsync(Candidate candidate);
        Task UpdateCandidateAsync(Candidate candidate);
        Task DeleteCandidateAsync(int id);
    }
}