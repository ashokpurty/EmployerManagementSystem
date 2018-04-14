using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EmployerManagementSystem.Models;

namespace EmployerManagementSystem.DataAcessLayer
{
    public class EMSContext : DbContext 
    {
        public EMSContext()
            : base("EMSContext")
        {
        }

        public DbSet<Employer> Employers { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}