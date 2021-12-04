using Domain.Entities;
using MediatR;
using Services.Repository.CurriculumRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Query.CurriculumQuery
{
    public class CurriculumQueryHandler :

        IRequestHandler<GetCurriculumQuery, Curriculum>,
                IRequestHandler<ListCurriculumByUserQuery, List<Curriculum>>


    {
        private readonly ICurriculumRepository _repository;

        public CurriculumQueryHandler(
           ICurriculumRepository phasesRepository)
        {
            _repository = phasesRepository;
        }

   

        public Task<Curriculum> Handle(GetCurriculumQuery request, CancellationToken cancellationToken)
        {
            return _repository.getCurriculum(request.Id);
        }

        public Task<List<Curriculum>> Handle(ListCurriculumByUserQuery request, CancellationToken cancellationToken)
        {
            return _repository.getListCurriculumByUser(request.IdUser);
        }
    }
}