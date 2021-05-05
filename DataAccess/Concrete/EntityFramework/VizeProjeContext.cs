using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class VizeProjeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OperationalDefinition> OperationalDefinitions { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<WorkStation> WorkStations { get; set; }
    }
}
