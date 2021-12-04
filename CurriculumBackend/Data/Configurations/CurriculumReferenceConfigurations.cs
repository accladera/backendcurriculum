using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Data.Configurations
{
    class CurriculumReferenceConfigurations : IEntityTypeConfiguration<CurriculumReference>
    {
        public virtual void Configure(EntityTypeBuilder<CurriculumReference> builder)
        {
            // 1 a n
            builder
            .HasOne<Curriculum>(s => s.Curriculum)
           .WithMany(g => g.CurReferences)
           .HasForeignKey(s => s.CurriculumId);

            builder.Property(x => x.Id).HasColumnName("nCurriculumReferenceId").IsRequired();
        builder.Property(x => x.Name).HasColumnName("sName");
        builder.Property(x => x.Company).HasColumnName("sCompany");
        builder.Property(x => x.Cellphone).HasColumnName("sCellphone");
        builder.Property(x => x.CurriculumId).HasColumnName("nCurriculumId").IsRequired();
        }
        
    }
}
