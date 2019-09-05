using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
    public class engage_interviewConfig : EntityTypeConfiguration<engage_interview>
    {
        public engage_interviewConfig()
        {
            this.ToTable(nameof(engage_interview));
            this.Property(e => e.human_name).HasMaxLength(60);
            this.Property(e => e.human_major_kind_id).HasMaxLength(2);
            this.Property(e => e.human_major_kind_name).HasMaxLength(60);
            this.Property(e => e.human_major_id).HasMaxLength(2);
            this.Property(e => e.human_major_name).HasMaxLength(60);
            this.Property(e => e.image_degree).HasMaxLength(60);
            this.Property(e => e.native_language_degree).HasMaxLength(60);
            this.Property(e => e.foreign_language_degree).HasMaxLength(60);
            this.Property(e => e.response_speed_degree).HasMaxLength(60);
            this.Property(e => e.EQ_degree).HasMaxLength(60);
            this.Property(e => e.IQ_degree).HasMaxLength(60);
            this.Property(e => e.multi_quality_degree).HasMaxLength(60);
            this.Property(e => e.register).HasMaxLength(60);
            this.Property(e => e.checker).HasMaxLength(60);
        }
    }
}
