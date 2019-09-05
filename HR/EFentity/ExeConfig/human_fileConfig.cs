using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
    public class human_fileConfig : EntityTypeConfiguration<human_file>
    {
        public human_fileConfig()
        {
            this.ToTable(nameof(human_file));
            this.Property(e => e.human_name).HasMaxLength(60);
            this.Property(e => e.human_address).HasMaxLength(200);
            this.Property(e => e.human_postcode).HasMaxLength(10);
            this.Property(e => e.human_major_kind_id).HasMaxLength(2);
            this.Property(e => e.human_major_kind_name).HasMaxLength(60);
            this.Property(e => e.human_major_id).HasMaxLength(2);
            this.Property(e => e.human_telephone).HasMaxLength(60);
            this.Property(e => e.human_mobilephone).HasMaxLength(60);
            this.Property(e => e.human_email).HasMaxLength(60);
            this.Property(e => e.human_hobby).HasMaxLength(200);
            this.Property(e => e.human_speciality).HasMaxLength(200);
            this.Property(e => e.human_sex).HasMaxLength(2);
            this.Property(e => e.human_religion).HasMaxLength(60);
            this.Property(e => e.human_party).HasMaxLength(60);
            this.Property(e => e.human_nationality).HasMaxLength(60);
            this.Property(e => e.human_race).HasMaxLength(60);
            this.Property(e => e.human_educated_degree).HasMaxLength(60);
            this.Property(e => e.human_educated_major).HasMaxLength(60);
            this.Property(e => e.human_id_card).HasMaxLength(60).IsRequired();

        }
    }
}
