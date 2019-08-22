using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFentity.ExeConfig
{
  public  class public_charConfig :EntityTypeConfiguration<public_char>
    {
      public public_charConfig()
        {
            this.ToTable(nameof(public_char));
            this.Property(e =>e.attribute_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.attribute_kind).HasMaxLength(60).IsRequired();
        }
    }
}
