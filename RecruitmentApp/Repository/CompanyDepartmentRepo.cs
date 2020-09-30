using RecruitmentApp.Container;
using RecruitmentApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentApp.Repository
{
    public class CompanyDepartmentRepo : ICompanyDepartmentRepo
    {
        private readonly dbContainer db;

        public CompanyDepartmentRepo(dbContainer db)
        {
            this.db = db;
        }

        public bool AddCompanyDepartment(Lk_Company_Department companyDepartment)
        {
            try
            {
                db.CompanyDepartments.Add(companyDepartment);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteCompanyDepartment(Lk_Company_Department companyDepartment)
        {
            try
            {
                db.CompanyDepartments.Remove(companyDepartment);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool EditCompanyDepartment(Lk_Company_Department newCompanyDepartment)
        {
            try
            {
                var oldData = db.CompanyDepartments.Find(newCompanyDepartment.CompanyId, newCompanyDepartment.DepartmentName);
                oldData = newCompanyDepartment;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
