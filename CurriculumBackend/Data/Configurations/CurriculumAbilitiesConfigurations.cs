using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;


namespace Data.Configurations
{
    class CurriculumAbilitiesConfigurations : IEntityTypeConfiguration<CurriculumAbilities>
    {

        public virtual void Configure(EntityTypeBuilder<CurriculumAbilities> builder)
        {

            // 1 a n
            builder
            .HasOne<Curriculum>(s => s.Curriculum)
           .WithMany(g => g.CurAbilities)
           .HasForeignKey(s => s.CurriculumId);


            builder.Property(x => x.Id).HasColumnName("nCurriculumAbilitiesId").IsRequired();
            builder.Property(x => x.Ability).HasColumnName("sAbility");
            builder.Property(x => x.ExperienceYears).HasColumnName("nExperienceYears");
            builder.Property(x => x.CurriculumId).HasColumnName("nCurriculumId").IsRequired();
        }
    }
}
