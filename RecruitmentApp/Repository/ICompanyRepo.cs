using RecruitmentApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentApp.Repository
{
    public interface ICompanyRepo
    {
        bool AddCompany(Lk_Company company);
        bool EditCompay(Lk_Company newCompany);
        bool DeleteCompany(Lk_Company company);
        int GetCompanyId(string companyName);
        string GetCompanyName(int companyId);
        IEnumerable<Lk_Company> GetAllCompanies();
    }
}
