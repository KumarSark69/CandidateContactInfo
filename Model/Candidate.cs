using System;
 
namespace CandidateContactInfo.Models{

    public class Candidate{
        
        public int candidateId{get; set;}
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber{get;set;}
        public string Email { get; set; }
        public string LinkedInUrl{get;set;}
        public string GitHubUrl{get;set;}
        public string comment{get;set;}
        public string timeInterval{get;set;}

    }
}
