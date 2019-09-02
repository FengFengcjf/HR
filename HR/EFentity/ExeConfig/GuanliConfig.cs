using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFentity.ExeConfig
{
  public  class GuanliConfig:EntityTypeConfiguration<Guanli>
    {
        public GuanliConfig()
        {
            this.ToTable(nameof(Guanli));
            this.Property(e => e.gname).HasMaxLength(20).IsRequired();
        }
    }
}
