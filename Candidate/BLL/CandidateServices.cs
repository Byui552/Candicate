using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CandidateServices
    {
        public List<Candidate> GetAllCandidate()
        {
            Model1 db = new Model1();
            return db.Candidates.ToList();
        }

        public List<CandidateSkill> GetCandidateSkills(int SkillNo, int ExperimentYear, int ExpectedSalary)
        {
            Model1 db = new Model1();
            var temp = db.CandidateSkills.Where(p => p.SkillNo == SkillNo).ToList();
            foreach (CandidateSkill skill in temp) 
            {
                if (skill.Candidate.WorkExperienceYear < ExperimentYear && skill.Candidate.ExpectedSalary > ExpectedSalary)
                {
                    temp.Remove(skill);
                }
            }
            return temp;
        }
    }
}
