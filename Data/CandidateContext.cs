using CandidateContactInfo.Models;
using Microsoft.EntityFrameworkCore;

namespace CandidateContactInfo.Data
{
    public class CandidateContext : DbContext
    {
        public CandidateContext(DbContextOptions<CandidateContext> options) : base(options) { }

        public DbSet<Candidate> Candidate { get; set; }

     
    }

}