using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Command.CurriculumCommand
{
    public class StoreCurriculumStudiesCommand : IRequest<bool>
    {
        public int? Id { get; set; }

        public string School { get; set; }


        public int LevelStudyIdSchool { get; set; }

        public int CountryIdSchool { get; set; }

        public DateTime Init { get; set; }

        public DateTime Finish { get; set; }

        public bool CurrentlyStudyingHere { get; set; }


        public string University { get; set; }

        public string Semester { get; set; }

        public int LevelStudyIdUniversity { get; set; }

        public int CountryIdUniversity { get; set; }

        public int CurriculumId { get; set; }
        public void SetId(int id) => Id = id;

    }
}