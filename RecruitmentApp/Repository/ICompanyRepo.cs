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

        bool EditCompay(int id,  string newCompName);

        bool DeleteCompany(Lk_Company company);

        int GetCompanyId(string companyName);

        Lk_Company GetCompany(int Id);

        IEnumerable<Lk_Company> GetAllCompanies();

        IEnumerable<string> GetCompanyDepartments(int id);

        string GetCompanyName(int companyId);
    }
}
