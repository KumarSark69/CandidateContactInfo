using CandidateContactInfo.Models;
using CandidateContactInfo.Repositories;
using CandidateContactInfo.Services;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandidateContactInfo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetCandidates()
        {
            var candidate = await _candidateService.GetAllCandidatesAsync();
            return Ok(candidate);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Candidate>> GetCandidate(int id)
        {
            var candidate = await _candidateService.GetCandidateByIdAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            return Ok(candidate);
        }

        [HttpPost]
        public async Task<ActionResult<Candidate>> PostCandidate(Candidate candidate)
        {
            var createdCandidate = await _candidateService.AddCandidateAsync(candidate);
            return CreatedAtAction(nameof(GetCandidate), new { id = createdCandidate.candidateId }, createdCandidate);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidate(int id, Candidate candidate)
        {
            if (id != candidate.candidateId)
            {
                return BadRequest();
            }
            await _candidateService.UpdateCandidateAsync(candidate);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCandidate(int id)
        {
            await _candidateService.DeleteCandidateAsync(id);
            return NoContent();
        }
    }
}