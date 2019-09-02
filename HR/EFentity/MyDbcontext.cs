using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using EFentity;

namespace EFentity
{
  public   class MyDbcontext:DbContext
    {
      
        public MyDbcontext():base("name=sql")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbcontext>());
            Database.SetInitializer<MyDbcontext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<users> userss { get; set; }
        public DbSet<config_major> config_major { get; set; }
        public DbSet<config_major_kind> config_major_kind { get; set; }
        public DbSet<config_public_char> config_public_char { get; set; }

    //    public DbSet<public_char> public_char { get; set; }
        public DbSet<config_file_first_kind> config_file_first_kinds { get; set; }
        public DbSet<config_file_second_kind> config_file_second_kinds { get; set; }
        public DbSet<config_file_third_kind> config_file_third_kinds { get; set; }
        public DbSet<standard_details> standard_details { get; set; }
        public DbSet<Guanli> Guanlis { get; set; }
    }
}
