using RecruitmentApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentApp.Repository
{
    public interface ICandidateRepo
    {
        bool AddCandidate(Op_Candidates candidate);

        bool EditCandidate(Op_Candidates newCandidate);
        
        Op_Candidates CandidateLoginChecker(string email, string password);

        IEnumerable<Op_Application> GetCandidateApplications(Op_Candidates candidate);
    }
}
