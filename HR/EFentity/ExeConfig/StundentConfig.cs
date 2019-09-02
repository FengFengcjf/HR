using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFentity.ExeConfig
{
   public  class StundentConfig:EntityTypeConfiguration<Student>
    {
        public StundentConfig()
        {
            this.ToTable(nameof(Student));
            this.Property(e => e.Name).HasMaxLength(20).IsRequired();
        }
    }
}
