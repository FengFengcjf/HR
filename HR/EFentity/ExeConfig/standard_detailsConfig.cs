using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFentity.ExeConfig
{
   public class standard_detailsConfig:EntityTypeConfiguration<standard_details>
    {
        public standard_detailsConfig()
        {
            this.ToTable(nameof(standard_details));
            this.Property(e => e.standard_name).HasMaxLength(30);
            this.Property(e => e.standard_id).HasMaxLength(30);
            this.Property(e => e.item_name).HasMaxLength(30);                     
        } 
    }
}
