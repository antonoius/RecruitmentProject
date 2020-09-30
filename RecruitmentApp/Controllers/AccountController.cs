using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecruitmentApp.Models;
using RecruitmentApp.Repository;

namespace RecruitmentApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IEmployeeLoginDataRepo eldRep;
        private readonly ICandidateRepo candRep;

        public AccountController(IEmployeeLoginDataRepo eldRep, ICandidateRepo candRep)
        {
            this.eldRep = eldRep;
            this.candRep = candRep;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM data)
        {

            var emp = eldRep.EmployeeLoginChecker(data.LoginEmail, data.Password);
            var cand = candRep.CandidateLoginChecker(data.LoginEmail, data.Password);
            if (emp == null && cand == null)
            {
                ViewBag.msg = "Invalid Email or Password";
                return View();
            }
            else if (emp != null)
            {
                if (emp.EmployeeTypeId == 1) return RedirectToAction("Index", "Admin"); // admin page
                else if (emp.EmployeeTypeId == 2) return RedirectToAction(""); // HR director page
                else return RedirectToAction(""); // recruiter page
            }
            else
            {
                return RedirectToAction(""); // candidate page
            }

        }

    }
}
