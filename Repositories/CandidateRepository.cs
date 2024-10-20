using CandidateContactInfo.Data;
using CandidateContactInfo.Models;
using Microsoft.EntityFrameworkCore;


namespace CandidateContactInfo.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly CandidateContext _context;

        public CandidateRepository(CandidateContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Candidate>> GetAllCandidatesAsync()
        {
            return await _context.Candidate.ToListAsync();
        }

        public async Task<Candidate> GetCandidateByIdAsync(int id)
        {
            return await _context.Candidate.FindAsync(id);
        }

        public async Task<Candidate> AddCandidateAsync(Candidate candidate)
        {
            _context.Candidate.Add(candidate);
            await _context.SaveChangesAsync();
            return candidate;
        }

        public async Task UpdateCandidateAsync(Candidate candidate)
        {
            _context.Entry(candidate).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCandidateAsync(int id)
        {
            var candidate = await _context.Candidate.FindAsync(id);
            if (candidate != null)
            {
                _context.Candidate.Remove(candidate);
                await _context.SaveChangesAsync();
            }
        }
    }
}