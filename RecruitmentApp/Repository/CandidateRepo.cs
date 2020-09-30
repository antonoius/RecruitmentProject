using RecruitmentApp.Container;
using RecruitmentApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentApp.Repository
{
    public class CandidateRepo : ICandidateRepo
    {
        private readonly dbContainer db;

        public CandidateRepo(dbContainer db)
        {
            this.db = db;
        }

        public bool AddCandidate(Op_Candidates candidate)
        {
            try
            {
                db.Candidates.Add(candidate);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Op_Candidates CandidateLoginChecker(string email, string password)
        {
            try
            {
                var cand = db.Candidates.SingleOrDefault(a => a.Email == email && a.Password == password);
                if (cand == default(Op_Candidates)) return default(Op_Candidates);
                else return cand;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default(Op_Candidates);
            }

        }

        public bool EditCandidate(Op_Candidates newCandidate)
        {
            try
            {
                var oldData = db.Candidates.Find(newCandidate.Id);
                oldData = newCandidate;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public IEnumerable<Op_Application> GetCandidateApplications(Op_Candidates candidate)
        {
            return db.Applications.Where(a => a.CandidateId == candidate.Id);
        }
    }
}
