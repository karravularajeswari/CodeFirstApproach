using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCPractice.Models
{
    public class CodeFirstContext:DbContext
    {
        public CodeFirstContext():base("name=CodeFirstConnection")
        {

        }
        public DbSet<Students> StudentsTable { get; set; }
        public DbSet<Departments> DepartmentsTable { get; set; }
    }
}