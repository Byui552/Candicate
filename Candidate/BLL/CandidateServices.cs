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
            List<CandidateSkill> temp = db.CandidateSkills.Where(p => p.SkillNo == SkillNo).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Candidate.WorkExperienceYear == null)
                {
                    temp[i].Candidate.WorkExperienceYear = 0;
                }
                if (temp[i].Candidate.ExpectedSalary == null)
                {
                    temp[i].Candidate.ExpectedSalary = 0;
                }
            }
            List<CandidateSkill> listCandidate = new List<CandidateSkill>();
            foreach (CandidateSkill skill in temp)
            {
                if (ExpectedSalary == 0 && skill.Candidate.WorkExperienceYear >= ExperimentYear)
                {
                    listCandidate.Add(skill);
                }
                else if (skill.Candidate.WorkExperienceYear >= ExperimentYear && skill.Candidate.ExpectedSalary <= ExpectedSalary)
                {
                    listCandidate.Add(skill);
                }
            }
            return listCandidate;
        }
    }
}
