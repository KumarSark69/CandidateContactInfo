
using System.Collections.Generic;
using System.Threading.Tasks;
using CandidateContactInfo.Models;

namespace CandidateContactInfo.Services
{
    public interface ICandidateService
    {
        Task<IEnumerable<Candidate>> GetAllCandidatesAsync();
        Task<Candidate> GetCandidateByIdAsync(int id);
        Task<Candidate> AddCandidateAsync(Candidate candidate);
        Task UpdateCandidateAsync(Candidate candidate);
        Task DeleteCandidateAsync(int id);
    }
}