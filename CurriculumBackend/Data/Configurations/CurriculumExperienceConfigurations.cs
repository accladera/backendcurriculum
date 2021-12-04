using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;


namespace Data.Configurations
{
    class CurriculumExperienceConfigurations : IEntityTypeConfiguration<CurriculumExperience>
    {
         public virtual void Configure(EntityTypeBuilder<CurriculumExperience> builder)
        {
            // 1 a n
            builder
            .HasOne<Curriculum>(s => s.Curriculum)
           .WithMany(g => g.CurExperiences)
           .HasForeignKey(s => s.CurriculumId);

            builder.Property(x => x.Id).HasColumnName("nCurriculumExperienceId").IsRequired();
            builder.Property(x => x.Position).HasColumnName("sPosition");
            builder.Property(x => x.AreaWorkId).HasColumnName("nAreaWorkId");
            builder.Property(x => x.Company).HasColumnName("sCompany").IsRequired();
            builder.Property(x => x.Ubication).HasColumnName("sUbication");
            builder.Property(x => x.CurrentlyHasThePosition).HasColumnName("bCurrentlyHasThePosition");
            builder.Property(x => x.DateInit).HasColumnName("dDateInit");
            builder.Property(x => x.DateFinish).HasColumnName("dDateFinish");
            builder.Property(x => x.ExperienceYears).HasColumnName("nExperienceYears");
            builder.Property(x => x.Dependents).HasColumnName("nDependents");
            builder.Property(x => x.Description).HasColumnName("sDescription");
            builder.Property(x => x.CurriculumId).HasColumnName("nCurriculumId").IsRequired();
            builder.Property(x => x.CountryId).HasColumnName("nCountryId");

        }
    }
}
