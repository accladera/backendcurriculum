using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Command.CurriculumCommand
{
    public class StoreCurriculumAditionalInformationCommand : IRequest<bool>
    {

        public int? Id { get; set; }

        public string Information { get; set; }

        public int CurriculumId { get; set; }

        public void SetId(int id) => Id = id;

    }
}