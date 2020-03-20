using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PMS_Application.API.Models
{
    public class PMSContext : DbContext
    {
        public PMSContext() : base("connection")
        {

        }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Technology> Technology { get; set; }
        public DbSet<Leave> Leave{ get; set; }
        public DbSet<Event> Event{ get; set; }
        public DbSet<Holiday> Holiday{ get; set; }
        public DbSet<Requirement> Requirement{ get; set; }
        public DbSet<Request> Request{ get; set; }
        public DbSet<TraineeDetails> TraineeDetails{ get; set; }
        public DbSet<TimeSheet> TimeSheet{ get; set; }
        public DbSet<Resignation> Resignation{ get; set; }









        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}