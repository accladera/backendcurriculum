using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Query.CurriculumQuery
{
    public class ListCurriculumByUserQuery : IRequest<List<Domain.Entities.Curriculum>>
    {
        public int IdUser { get; set; }
    }
}
