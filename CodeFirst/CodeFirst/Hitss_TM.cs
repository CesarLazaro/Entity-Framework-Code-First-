using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    class Hitss_TM2 : DbContext
    {
        public DbSet<Cat_Role> Cat_Role { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeProject> EmployeeProject { get; set; }
        public DbSet<Project> Project { get; set; }

    }
}
