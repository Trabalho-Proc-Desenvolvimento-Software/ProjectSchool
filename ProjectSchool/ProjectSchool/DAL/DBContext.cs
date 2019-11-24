using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjectSchool.DAL
{
    public class DBContext : DbContext
    {

        public DBContext() : base("SchoolDb")
        {
        }

        //public DbSet<Student> Students { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}