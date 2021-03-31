using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatSapravl.Models;

namespace RecruitCatSapravl.Data
{
    public class RecruitCatSapravlContext : DbContext
    {
        public RecruitCatSapravlContext (DbContextOptions<RecruitCatSapravlContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatSapravl.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatSapravl.Models.Company> Company { get; set; }

        public DbSet<RecruitCatSapravl.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatSapravl.Models.JobTitle> JobTitle { get; set; }
    }
}
