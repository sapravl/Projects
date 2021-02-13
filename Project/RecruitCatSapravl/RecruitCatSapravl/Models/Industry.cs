using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatSapravl.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        [DisplayName("Industry Name")]
        [Required]
        [StringLength(20)]
        public string IndustryName { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
