using RecruitmentApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentApp.Repository
{
    public interface IApplicationRepo
    {
        bool AddApplication(Op_Application application);
        
        bool EditApplication(Op_Application newApplication);

        bool ApplicatonChecker(int candidateId, int jobId);

        bool SetApplicationStartDate(Op_Application application);

        bool SetApplicationEndDate(Op_Application application);
        string GetApplicationStatusName(int statusId);
        string GetPhaseName(int PhaseId);

        IEnumerable<Op_Application> GetCompanyRunningApplications(int companyId);

        //IEnumerable<Op_Application> GetCandidateApplications(string email, string phone, string linkedInAccount);

    }
}
