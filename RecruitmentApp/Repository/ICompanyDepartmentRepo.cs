using RecruitmentApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentApp.Repository
{
    public interface ICompanyDepartmentRepo
    {
        bool AddCompanyDepartment(Lk_Company_Department companyDepartment);
        
        bool EditCompanyDepartment(Lk_Company_Department newCompanyDepartment);
        
        bool DeleteCompanyDepartment(Lk_Company_Department companyDepartment);
        
    }
}
