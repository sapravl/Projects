using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSapravl.Data;
using RecruitCatSapravl.Models;

namespace RecruitCatSapravl.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatSapravl.Data.RecruitCatSapravlContext _context;

        public IndexModel(RecruitCatSapravl.Data.RecruitCatSapravlContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; }

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
