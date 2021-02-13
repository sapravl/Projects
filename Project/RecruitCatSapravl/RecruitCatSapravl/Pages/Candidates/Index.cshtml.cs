﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSapravl.Data;
using RecruitCatSapravl.Models;

namespace RecruitCatSapravl.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatSapravl.Data.RecruitCatSapravlContext _context;

        public IndexModel(RecruitCatSapravl.Data.RecruitCatSapravlContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}