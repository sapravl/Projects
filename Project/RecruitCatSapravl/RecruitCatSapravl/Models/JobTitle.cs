using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSapravl.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string Title { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public int Vacancies { get; set; }
        public string Responsibilities { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
