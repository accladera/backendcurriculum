using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Command.CurriculumCommand
{
    public class StoreCurriculumIdiomCommand : IRequest<bool>
    {
        public int? Id { get; set; }

        public int IdomId { get; set; }

        public int LevelWrite { get; set; }


        public int LevelOral { get; set; }


        public int LevelRead { get; set; }


        public int CurriculumId { get; set; }

        public void SetId(int id) => Id = id;


    }
}