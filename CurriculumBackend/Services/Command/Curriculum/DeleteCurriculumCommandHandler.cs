using MediatR;
using Services.Repository.CurriculumRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Command.CurriculumCommand
{
    public class DeleteCurriculumCommandHandler : IRequestHandler<DeleteCurriculumCommand, bool>
       

    {
        private readonly ICurriculumRepository _repository;


        public DeleteCurriculumCommandHandler(
            ICurriculumRepository curriculumRepository
           ) : base()
        {
            _repository = curriculumRepository;

        }

        public Task<bool> Handle(DeleteCurriculumCommand request, CancellationToken cancellationToken)
        {
            return this._repository.Delete(request.CurriculumId);
        }
    }
}
