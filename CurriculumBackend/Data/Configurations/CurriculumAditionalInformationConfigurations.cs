using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;


namespace Data.Configurations
{
    class CurriculumAditionalInformationConfigurations : IEntityTypeConfiguration<CurriculumAditionalInformation>
    {
         public virtual void Configure(EntityTypeBuilder<CurriculumAditionalInformation> builder)
        {
            // 1 a n
            builder
            .HasOne<Curriculum>(s => s.Curriculum)
           .WithMany(g => g.CurAdionalInformations)
           .HasForeignKey(s => s.CurriculumId);

            builder.Property(x => x.Id).HasColumnName("nCurriculumAditionalInformationId").IsRequired();
        builder.Property(x => x.Information).HasColumnName("sInformation");
        builder.Property(x => x.CurriculumId).HasColumnName("nCurriculumId").IsRequired();
       
        }
    }
}
