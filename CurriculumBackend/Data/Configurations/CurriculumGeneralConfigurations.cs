using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Data.Configurations
{
    class CurriculumGeneralConfigurations : IEntityTypeConfiguration<CurriculumGeneral>
    {
        public virtual void Configure(EntityTypeBuilder<CurriculumGeneral> builder)
        {
            // 1 a n
            builder
            .HasOne<Curriculum>(s => s.Curriculum)
           .WithMany(g => g.CurGenerals)
           .HasForeignKey(s => s.CurriculumId);

            builder.Property(x => x.Id).HasColumnName("nCurriculumGeneralId").IsRequired();
            builder.Property(x => x.Title).HasColumnName("sTitle").IsRequired();
            builder.Property(x => x.CategoryId).HasColumnName("nCategoryId");
            builder.Property(x => x.ContractTypeId).HasColumnName("nContractTypeId");
            builder.Property(x => x.Salary).HasColumnName("sSalary");
            builder.Property(x => x.CountryReferenceId).HasColumnName("nCountryReferenceId");
            builder.Property(x => x.Presentation).HasColumnName("sPresentation");
            builder.Property(x => x.CurriculumId).HasColumnName("nCurriculumId").IsRequired();

        }
    }
}
