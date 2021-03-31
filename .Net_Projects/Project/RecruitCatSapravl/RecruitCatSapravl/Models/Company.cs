using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RecruitCatSapravl.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [DisplayName("Company Name")]
        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }
        [DisplayName("Position Recruiting")]
        [Required]
        [StringLength(20)]
        public string PositionRecruiting { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(1,999999)]
        public decimal MinimumSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(1, 999999)]
        public decimal MaximumSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        [DisplayName("Performance Bonus")]
        [Range(1, 99999)]
        public decimal? PerformanceBonus { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }
        public JobTitle JobTitle { get; set; }
        [DisplayName("Job Title ID")]
        public int JobTitleId { get; set; }
    }
}
