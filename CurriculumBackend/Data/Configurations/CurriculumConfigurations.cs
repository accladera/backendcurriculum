using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;


namespace Data.Configurations
{
    public class CurriculumConfigurations : IEntityTypeConfiguration<Curriculum>
    {
        public virtual void Configure(EntityTypeBuilder<Curriculum> builder)
        {
           
            builder.Property(x => x.Id).HasColumnName("nCurriculumId").IsRequired();
            builder.Property(x => x.Name).HasColumnName("sName").IsRequired();
            builder.Property(x => x.LastName).HasColumnName("sLastName").IsRequired();
            builder.Property(x => x.Cellphone).HasColumnName("sCellphone").IsRequired();
            builder.Property(x => x.Phone).HasColumnName("sPhone");
            builder.Property(x => x.Nationality).HasColumnName("sNationality");
            builder.Property(x => x.TypeDocumentId).HasColumnName("nTypeDocumentId").IsRequired();
            builder.Property(x => x.DocumentNumber).HasColumnName("nDocumentNumber").IsRequired();
            builder.Property(x => x.Birthday).HasColumnName("dBirthday");
            builder.Property(x => x.GenderId).HasColumnName("nGenderId").IsRequired();
            builder.Property(x => x.MaritalStatusId).HasColumnName("nMaritalStatusId");
            builder.Property(x => x.ClientId).HasColumnName("nClientId").IsRequired();
          
        }
            
    }
}
