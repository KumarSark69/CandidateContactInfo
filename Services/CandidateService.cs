
using System.Collections.Generic;
using System.Threading.Tasks;
using CandidateContactInfo.Models;
using CandidateContactInfo.Repositories;

namespace CandidateContactInfo.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<IEnumerable<Candidate>> GetAllCandidatesAsync()
        {
            return await _candidateRepository.GetAllCandidatesAsync();
        }

        public async Task<Candidate> GetCandidateByIdAsync(int id)
        {
            return await _candidateRepository.GetCandidateByIdAsync(id);
        }

        public async Task<Candidate> AddCandidateAsync(Candidate candidate)
        {
            return await _candidateRepository.AddCandidateAsync(candidate);
        }

        public async Task UpdateCandidateAsync(Candidate candidate)
        {
            await _candidateRepository.UpdateCandidateAsync(candidate);
        }

        public async Task DeleteCandidateAsync(int id)
        {
            await _candidateRepository.DeleteCandidateAsync(id);
        }
    }
}