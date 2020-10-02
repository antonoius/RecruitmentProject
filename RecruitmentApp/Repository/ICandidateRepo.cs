﻿using RecruitmentApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentApp.Repository
{
    public interface ICandidateRepo
    {
        bool AddCandidate(Op_Candidates candidate);


        bool EditCandidate(int id, string Name, string Email, string Password, string UniversityName, string Major, int GraduationYear, string Phone, string LinkedIn, string Address);
        
        Op_Candidates CandidateLoginChecker(string email, string password);
        string GetCandidateName(int candidateId);
        Op_Candidates GetCandidate(int candidateId);

        IEnumerable<Op_Application> GetCandidateApplications(int CandidateId);
      
    }
}
