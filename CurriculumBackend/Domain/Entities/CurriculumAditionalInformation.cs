using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using Core.AggreateRoot;

namespace Domain.Entities
{
    public class CurriculumAditionalInformation : BaseModel,  IAggregateChild<Curriculum>
    {
        public CurriculumAditionalInformation(string information)
        {
            Information = information;
        }

        public override int Id { get; protected set; }

        public string? Information { get; set; }

        public int CurriculumId { get; set; }

        [JsonIgnore]
        public virtual Curriculum Curriculum { get; set; }

        internal void UpdateInformation(string information)
        {
            Information = information;
        }
    }
}
