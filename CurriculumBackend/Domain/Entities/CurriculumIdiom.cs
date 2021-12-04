using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using Core.AggreateRoot;

namespace Domain.Entities
{
    public class CurriculumIdiom : BaseModel,  IAggregateChild<Curriculum>
    {
        public CurriculumIdiom(int idiomId, int? levelWrite, int? levelOral, int? levelRead)
        {
            IdiomId = idiomId;
            LevelWrite = levelWrite;
            LevelOral = levelOral;
            LevelRead = levelRead;
        }

        public override int Id { get; protected set; }


        public int IdiomId { get; set; }

       
        public int? LevelWrite { get; set; }

        
        public int? LevelOral { get; set; }

       
        public int? LevelRead { get; set; }


        public int CurriculumId { get; set; }
        [JsonIgnore]
        public virtual Curriculum Curriculum { get; set; }

        internal void UpdateIdoms(int idiomId, int levelWrite, int levelOral, int levelRead)
        {
            IdiomId = idiomId;
            LevelWrite = levelWrite;
            LevelOral = levelOral;
            LevelRead = levelRead;
        }
    }
}
