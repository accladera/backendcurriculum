using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using Core.AggreateRoot;
using Core.Rules.PhoneNumber;

namespace Domain.Entities
{
    public class CurriculumReference : BaseModel,  IAggregateChild<Curriculum>
    {
     

        public override int Id { get; protected set; }


        public string? Name { get; set; }

        
        public string? Company { get; set; }

       
        public string? Cellphone { get; set; }


        public int CurriculumId { get; set; }
        [JsonIgnore]
        public virtual Curriculum Curriculum { get; set; }


        public CurriculumReference(string name, string company, string cellphone)
        {
            Name = name;
            Company = company;
            Cellphone = new PhoneNumberValue(cellphone); 
        }

        internal void UpdateReference(string name, string company, string cellphone)
        {
            Name = name;
            Company = company;
            Cellphone = new PhoneNumberValue(cellphone);
        }
    }
}
