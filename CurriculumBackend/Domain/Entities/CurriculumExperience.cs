using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using Core.AggreateRoot;

namespace Domain.Entities
{
    public class CurriculumExperience : BaseModel,  IAggregateChild<Curriculum>
    {
        public CurriculumExperience(string position, int? areaWorkId, string company, int countryId, string ubication, bool? currentlyHasThePosition, DateTime? dateInit, DateTime? dateFinish, int? experienceYears, int? dependents, string description)
        {
            Position = position;
            AreaWorkId = areaWorkId;
            Company = company;
            CountryId = countryId;
            Ubication = ubication;
            CurrentlyHasThePosition = currentlyHasThePosition;
            DateInit = dateInit;
            DateFinish = dateFinish;
            ExperienceYears = experienceYears;
            Dependents = dependents;
            Description = description;
        }

        public override int Id { get; protected set; }


        public string? Position { get; set; }

        
        public int? AreaWorkId { get; set; }

        
        public string Company { get; set; }

        public int CountryId { get; set; }


        public string? Ubication { get; set; }

       
        public bool? CurrentlyHasThePosition { get; set; }

       
        public DateTime? DateInit { get; set; }

       
        public DateTime? DateFinish { get; set; }

        
        public int? ExperienceYears { get; set; }

        
        public int? Dependents { get; set; }

        
        public string? Description { get; set; }



        public int CurriculumId { get; set; }
        [JsonIgnore]
        public virtual Curriculum Curriculum { get; set; }

        internal void UpdateExperence(string position, int areaWorkId, string company, int countryId, string ubication, bool currentlyHasThePosition, DateTime dateInit, DateTime dateFinish, int experienceYears, int dependents, string description)
        {
            Position = position;
            AreaWorkId = areaWorkId;
            Company = company;
            CountryId = countryId;
            Ubication = ubication;
            CurrentlyHasThePosition = currentlyHasThePosition;
            DateInit = dateInit;
            DateFinish = dateFinish;
            ExperienceYears = experienceYears;
            Dependents = dependents;
            Description = description;
        }
    }
}
