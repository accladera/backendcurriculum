using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Command.CurriculumCommand
{
    public class StoreCurriculumReferenceCommand : IRequest<bool>
    {
        public int? Id { get; set; }

        public string Name { get; set; }


        public string Company { get; set; }


        public string Cellphone { get; set; }


        public int CurriculumId { get; set; }
        public void SetId(int id) => Id = id;

    }
}