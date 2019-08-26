using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
   public  class usersConfig: EntityTypeConfiguration<users>
    {
        public usersConfig()
        {
            this.ToTable(nameof(users));
            this.Property(e => e.u_name).HasMaxLength(20).IsRequired();
            this.Property(e => e.u_true_name).HasMaxLength(20).IsRequired();
            this.Property(e => e.u_password).HasMaxLength(20).IsRequired();
        }
    }
}
