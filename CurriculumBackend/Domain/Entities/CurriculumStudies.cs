using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using Core.AggreateRoot;

namespace Domain.Entities
{
    public class CurriculumStudies : BaseModel, IAggregateChild<Curriculum>
    {
        public CurriculumStudies(string school, int? levelStudyIdSchool, int? countryIdSchool, DateTime? init, DateTime? finish, bool? currentlyStudyingHere, string university, string? semester, int? levelStudyIdUniversity, int? countryIdUniversity)
        {
            School = school;
            LevelStudyIdSchool = levelStudyIdSchool;
            CountryIdSchool = countryIdSchool;
            Init = init;
            Finish = finish;
            CurrentlyStudyingHere = currentlyStudyingHere;
            University = university;
            Semester = semester;
            LevelStudyIdUniversity = levelStudyIdUniversity;
            CountryIdUniversity = countryIdUniversity;
        }

        public override int Id { get; protected set; }


        public string School { get; set; }


        public int? LevelStudyIdSchool { get; set; }

        public int? CountryIdSchool { get; set; }


        public DateTime? Init { get; set; }


        public DateTime? Finish { get; set; }

        public bool? CurrentlyStudyingHere { get; set; }


        public string University { get; set; }


        public string? Semester { get; set; }

        public int? LevelStudyIdUniversity { get; set; }

        public int? CountryIdUniversity { get; set; }


        public int CurriculumId { get; set; }
        [JsonIgnore]
        public virtual Curriculum Curriculum { get; set; }

        internal void UpdateStudies(string school, int levelStudyIdSchool, int countryIdSchool, DateTime init, DateTime finish, bool currentlyStudyingHere, string university, string semester, int levelStudyIdUniversity, int countryIdUniversity)
        {
            School = school;
            LevelStudyIdSchool = levelStudyIdSchool;
            CountryIdSchool = countryIdSchool;
            Init = init;
            Finish = finish;
            CurrentlyStudyingHere = currentlyStudyingHere;
            University = university;
            Semester = semester;
            LevelStudyIdUniversity = levelStudyIdUniversity;
            CountryIdUniversity = countryIdUniversity;
        }
    }
}
