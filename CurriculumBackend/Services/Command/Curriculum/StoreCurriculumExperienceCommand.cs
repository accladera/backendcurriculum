using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Command.CurriculumCommand
{
    public class StoreCurriculumExperienceCommand : IRequest<bool>
    {
        public int? Id { get; set; }

        public string Position { get; set; }

        public string Company { get; set; }

        public int AreaWorkId { get; set; }

        public int CountryId { get; set; }

        public string Ubication { get; set; }

        public DateTime DateInit { get; set; }


        public DateTime DateFinish { get; set; }

        public bool CurrentlyHasThePosition { get; set; }

        public int Dependents { get; set; }

        public int ExperienceYears { get; set; }


        public string Description { get; set; }

        public int CurriculumId { get; set; }

        public void SetId(int id) => Id = id;

    }
}