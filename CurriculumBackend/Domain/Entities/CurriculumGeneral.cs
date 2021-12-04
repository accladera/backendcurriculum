using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using Core.AggreateRoot;

namespace Domain.Entities
{
    public class CurriculumGeneral : BaseModel, IAggregateChild<Curriculum>
    {
        public CurriculumGeneral(string title, int? categoryId, int? contractTypeId, string salary, int? countryReferenceId, string presentation)
        {
            Title = title;
            CategoryId = categoryId;
            ContractTypeId = contractTypeId;
            Salary = salary;
            CountryReferenceId = countryReferenceId;
            Presentation = presentation;
        }

        public override int Id { get; protected set; }


        public string Title { get; set; }

        
        public int? CategoryId { get; set; }
    
        
        public int? ContractTypeId { get; set; }
    
        
        public string? Salary { get; set; }
    
        
        public int? CountryReferenceId { get; set; }
    
        
        public string? Presentation { get; set; }



        public int CurriculumId { get; set; }
        [JsonIgnore]
        public virtual Curriculum Curriculum { get; set; }

        internal void UpdateGeneral(string title, int categoryId, int contractTypeId, string salary, int countryReferenceId, string presentation)
        {
            Title = title;
            CategoryId = categoryId;
            ContractTypeId = contractTypeId;
            Salary = salary;
            CountryReferenceId = countryReferenceId;
            Presentation = presentation;
        }
    }
}
