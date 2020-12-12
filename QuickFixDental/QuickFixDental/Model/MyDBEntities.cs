using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.Model
{
    public class MyDBEntities : DbContext
    {
        public MyDBEntities()
            : base("name=conString")
        {

            //  Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDBEntities);
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<TreatmentPlan> TreatmentPlans { get; set; }
        public DbSet<MedicalHistory> MedicalHistorys { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    }
