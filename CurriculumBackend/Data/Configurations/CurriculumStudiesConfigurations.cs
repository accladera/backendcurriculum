using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;


namespace Data.Configurations
{
    class CurriculumStudiesConfigurations : IEntityTypeConfiguration<CurriculumStudies>
    {
        public virtual void Configure(EntityTypeBuilder<CurriculumStudies> builder)
        {
            // 1 a n
            builder
            .HasOne<Curriculum>(s => s.Curriculum)
           .WithMany(g => g.CurStudies)
           .HasForeignKey(s => s.CurriculumId);

            builder.Property(x => x.Id).HasColumnName("nCurriculumId").IsRequired();
        builder.Property(x => x.School).HasColumnName("sSchool").IsRequired();
        builder.Property(x => x.LevelStudyIdSchool).HasColumnName("nLevelStudyIdSchool");
        builder.Property(x => x.CountryIdSchool).HasColumnName("nCountryIdSchool");
        builder.Property(x => x.Init).HasColumnName("dInit");
        builder.Property(x => x.Finish).HasColumnName("dFinish");
        builder.Property(x => x.CurrentlyStudyingHere).HasColumnName("bCurrentlyStudyingHere");
        builder.Property(x => x.University).HasColumnName("sUniversity").IsRequired();
        builder.Property(x => x.Semester).HasColumnName("sSemester");
        builder.Property(x => x.LevelStudyIdUniversity).HasColumnName("nLevelStudyIdUniversity");
        builder.Property(x => x.CountryIdUniversity).HasColumnName("nCountryIdUniversity");
        builder.Property(x => x.CurriculumId).HasColumnName("nCurriculumId");
    }
    }
}
