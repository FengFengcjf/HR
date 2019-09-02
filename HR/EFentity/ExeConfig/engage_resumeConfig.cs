using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFentity.ExeConfig
{
    public class engage_resumeConfig :EntityTypeConfiguration<engage_resume>
    {
        public engage_resumeConfig()
        {
            this.ToTable(nameof(engage_resume));
            this.Property(e => e.human_name).HasMaxLength(60);
            this.Property(e => e.engage_type).HasMaxLength(30);
            this.Property(e => e.human_address).HasMaxLength(200);
            this.Property(e => e.human_postcode).HasMaxLength(10);
            this.Property(e => e.human_major_kind_id).HasMaxLength(2);
            this.Property(e => e.human_major_kind_name).HasMaxLength(60);
            this.Property(e => e.human_major_id).HasMaxLength(2);
            this.Property(e => e.human_major_name).HasMaxLength(60);
            this.Property(e => e.human_telephone).HasMaxLength(60);
            this.Property(e => e.human_homephone).HasMaxLength(60);
            this.Property(e => e.human_mobilephone).HasMaxLength(60);
            this.Property(e => e.human_email).HasMaxLength(60);
            this.Property(e => e.human_hobby).HasMaxLength(200);
            this.Property(e => e.human_specility).HasMaxLength(200);
            this.Property(e => e.human_sex).HasMaxLength(2);
            this.Property(e => e.human_religion).HasMaxLength(60);
            this.Property(e => e.human_party).HasMaxLength(60);
            this.Property(e => e.human_nationality).HasMaxLength(60);
            this.Property(e => e.human_race).HasMaxLength(60);
            this.Property(e => e.human_educated_degree).HasMaxLength(60);
            this.Property(e => e.human_educated_major).HasMaxLength(60);
            this.Property(e => e.human_college).HasMaxLength(60);
            this.Property(e => e.human_idcard).HasMaxLength(60);

        }
    }
}
