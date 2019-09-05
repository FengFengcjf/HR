using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
    public class engage_major_releaseConfig: EntityTypeConfiguration<engage_major_release>
    {
        public engage_major_releaseConfig()
        {
            this.ToTable(nameof(engage_major_release));
            this.Property(e => e.first_kind_id).HasMaxLength(2);
            this.Property(e => e.first_kind_name).HasMaxLength(60);
            this.Property(e => e.second_kind_id).HasMaxLength(2);
            this.Property(e => e.second_kind_name).HasMaxLength(60);
            this.Property(e => e.third_kind_id).HasMaxLength(2);
            this.Property(e => e.third_kind_name).HasMaxLength(60);
            this.Property(e => e.major_kind_id).HasMaxLength(2);
            this.Property(e => e.major_kind_name).HasMaxLength(60);
            this.Property(e => e.major_id).HasMaxLength(2);
            this.Property(e => e.major_name).HasMaxLength(60);
            this.Property(e => e.engage_type).HasMaxLength(60);
            this.Property(e => e.register).HasMaxLength(60);
            this.Property(e => e.changer).HasMaxLength(60);
            this.Property(e => e.major_describe).HasMaxLength(60);
            this.Property(e => e.engage_required).HasMaxLength(60);
        }
    }
}
