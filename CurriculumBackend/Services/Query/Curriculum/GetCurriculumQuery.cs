using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Query.CurriculumQuery
{
    public class GetCurriculumQuery : IRequest<Domain.Entities.Curriculum>
    {
        public int Id { get; set; }
    }
}
