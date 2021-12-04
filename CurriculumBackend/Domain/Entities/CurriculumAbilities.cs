using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using Core.AggreateRoot;

namespace Domain.Entities
{
    public class CurriculumAbilities : BaseModel, IAggregateChild<Curriculum>
    {

        public override int Id { get; protected set; }


        public string? Ability { get; set; }

    
        public int ExperienceYears { get; set; }

        public int CurriculumId { get; set; }

        [JsonIgnore]
        public virtual Curriculum Curriculum{ get; set; }


        public CurriculumAbilities(string ability, int experienceYears)
        {
            Ability = ability;
            ExperienceYears = experienceYears;
        }

        internal void UpdateAbilities(string ability, int experencesYear)
        {
            Ability = ability;
            ExperienceYears = experencesYear;
        }
    }
}
