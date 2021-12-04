using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;


namespace Data.Configurations
{
    class CurriculumIdiomConfigurations : IEntityTypeConfiguration<CurriculumIdiom>
    {
        public virtual void Configure(EntityTypeBuilder<CurriculumIdiom> builder)
        {
            // 1 a n
            builder
            .HasOne<Curriculum>(s => s.Curriculum)
           .WithMany(g => g.CurIdiomes)
           .HasForeignKey(s => s.CurriculumId);

            builder.Property(x => x.Id).HasColumnName("nCurriculumIdiomId").IsRequired();
        builder.Property(x => x.IdiomId).HasColumnName("nIdiomId");
        builder.Property(x => x.LevelWrite).HasColumnName("nLevelWrite");
        builder.Property(x => x.LevelOral).HasColumnName("nLevelOral");
        builder.Property(x => x.LevelRead).HasColumnName("nLevelRead");
        builder.Property(x => x.CurriculumId).HasColumnName("nCurriculumId").IsRequired();
       
        }
    }
}
