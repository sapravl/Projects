using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RecruitCatSapravl.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        [Required]
        [StringLength(20)]
        public string Title { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(1, 999999)]
        public decimal MinimumSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(1, 999999)]
        public decimal MaximumSalary { get; set; }
        [Range(1, 9999)]
        public int Vacancies { get; set; }
        [StringLength(100)]
        public string Responsibilities { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
