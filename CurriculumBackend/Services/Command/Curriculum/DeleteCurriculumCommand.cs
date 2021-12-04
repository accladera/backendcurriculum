using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Command.CurriculumCommand
{
    public class DeleteCurriculumCommand : IRequest<bool>
    {
        public int CurriculumId { get; set; }
    }
}