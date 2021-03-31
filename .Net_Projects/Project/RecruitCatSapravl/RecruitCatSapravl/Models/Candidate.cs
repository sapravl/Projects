using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RecruitCatSapravl.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        [DisplayName("First Name")]
        [Required]
        [StringLength(12)]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        [StringLength(12)]
        public string LastName { get; set; }
        [DisplayName("Target Salary")]
        [Range(1,999999)]
        public decimal TargetSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DisplayName("Preffered Location")]
        [StringLength(20)]
        public string PrefferedLocation { get; set; }
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Is Married?")]
        public bool Married { get; set; }
        public Company Company { get; set; }
        [DisplayName("Company ID")]
        public int? CompanyId { get; set; }
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        [DisplayName("Job Title ID")]
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }
    }
}
