using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Command.CurriculumCommand
{
    public class StoreCurriculumGeneralCommand : IRequest<bool>
    {

        public int? Id { get; set; }

        public string Title { get; set; }


        public int CategoryId { get; set; }


        public int ContractTypeId { get; set; }


        public string Salary { get; set; }


        public int CountryReferenceId { get; set; }


        public string Presentation { get; set; }

        public int CurriculumId { get; set; }

        public void SetId(int id) => Id = id;

    }
}