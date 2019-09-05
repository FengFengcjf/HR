using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
    public class salary_standardConfig : EntityTypeConfiguration<salary_standard>
    {
        public salary_standardConfig()
        {
            this.ToTable(nameof(salary_standard));
            this.Property(e => e.standard_name).HasMaxLength(30);
            this.Property(e => e.standard_id).HasMaxLength(60);
            
        }
    }
}
