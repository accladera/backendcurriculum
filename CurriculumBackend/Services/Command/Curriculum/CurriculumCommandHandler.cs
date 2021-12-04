using Domain.Entities;
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
    public class CurriculumCommandHandler : IRequestHandler<StoreCurriculumCommand, int>, 
        IRequestHandler<StoreCurriculumAbilitiesCommand, bool>,
        IRequestHandler<StoreCurriculumAditionalInformationCommand, bool>,
        IRequestHandler<StoreCurriculumExperienceCommand, bool>,
         IRequestHandler<StoreCurriculumGeneralCommand, bool>,
        IRequestHandler<StoreCurriculumIdiomCommand, bool>,
         IRequestHandler<StoreCurriculumReferenceCommand, bool>,
           IRequestHandler<StoreCurriculumStudiesCommand, bool>


    {
        private readonly ICurriculumRepository _repository;
     

        public CurriculumCommandHandler(
            ICurriculumRepository userBpoksRepository
           ) : base()
        {
            _repository = userBpoksRepository;
       
        }

        public async Task<int> Handle(StoreCurriculumCommand request, CancellationToken cancellationToken)
        {
            Curriculum curriculum;
            if (request.Id.HasValue)
            {
                curriculum = await this._repository.getCurriculum(request.Id.Value);
                curriculum.UpdateCurriculum(request.Name, request.LastName, request.Cellphone, request.Phone, request.Nationality, request.TypeDocumentId,
               request.DocumentNumber, request.Birthday, request.GenderId, request.MaritalStatusId, request.ClientId);

            }
            else
            {
                curriculum = new Curriculum(request.Name, request.LastName, request.Cellphone, request.Phone, request.Nationality, request.TypeDocumentId,
               request.DocumentNumber, request.Birthday, request.GenderId, request.MaritalStatusId, request.ClientId);

                this._repository.Add(curriculum);
            }
           

            await this._repository.UnitOfWork.SaveEntitiesAsync();

            return curriculum.Id;
        }

        public async Task<bool> Handle(StoreCurriculumAbilitiesCommand request, CancellationToken cancellationToken)
        {
            Curriculum curriculum = await this._repository.getCurriculum(request.CurriculumId);

           
            curriculum.AddCurriculumAbilities(request.Ability, request.ExperienceYears,request.Id);
            

            this._repository.Update(curriculum);

            await this._repository.UnitOfWork.SaveEntitiesAsync();

            return true;

        }

        public async Task<bool> Handle(StoreCurriculumAditionalInformationCommand request, CancellationToken cancellationToken)
        {
            Curriculum curriculum = await this._repository.getCurriculum(request.CurriculumId);

            curriculum.AddCurriculumAditionInformation(request.Information,request.Id);

            this._repository.Update(curriculum);

            await this._repository.UnitOfWork.SaveEntitiesAsync();

            return true;
        }

        public async Task<bool> Handle(StoreCurriculumExperienceCommand request, CancellationToken cancellationToken)
        {
            Curriculum curriculum = await this._repository.getCurriculum(request.CurriculumId);

            curriculum.AddCurriculumAExperence(request.Position,request.AreaWorkId,request.Company,request.CountryId,request.Ubication,request.CurrentlyHasThePosition
                ,request.DateInit,request.DateFinish,request.ExperienceYears,request.Dependents,request.Description, request.Id);

            this._repository.Update(curriculum);

            await this._repository.UnitOfWork.SaveEntitiesAsync();

            return true;
        }

        public async Task<bool> Handle(StoreCurriculumGeneralCommand request, CancellationToken cancellationToken)
        {
            Curriculum curriculum = await this._repository.getCurriculum(request.CurriculumId);

            curriculum.AddCurriculumAGeneral(request.Title,request.CategoryId,request.ContractTypeId,request.Salary,request.CountryReferenceId,request.Presentation,request.Id);

            this._repository.Update(curriculum);

            await this._repository.UnitOfWork.SaveEntitiesAsync();

            return true;
        }

        public async Task<bool> Handle(StoreCurriculumIdiomCommand request, CancellationToken cancellationToken)
        {
            Curriculum curriculum = await this._repository.getCurriculum(request.CurriculumId);

            curriculum.AddCurriculumIdom(request.IdomId,request.LevelWrite,request.LevelOral,request.LevelRead,request.Id);

            this._repository.Update(curriculum);

            await this._repository.UnitOfWork.SaveEntitiesAsync();

            return true;
        }

        public async Task<bool> Handle(StoreCurriculumReferenceCommand request, CancellationToken cancellationToken)
        {
            Curriculum curriculum = await this._repository.getCurriculum(request.CurriculumId);

            curriculum.AddCurriculumReference(request.Name,request.Company,request.Cellphone,request.Id);

            this._repository.Update(curriculum);

            await this._repository.UnitOfWork.SaveEntitiesAsync();

            return true;
        }

        public async Task<bool> Handle(StoreCurriculumStudiesCommand request, CancellationToken cancellationToken)
        {
            Curriculum curriculum = await this._repository.getCurriculum(request.CurriculumId);

            curriculum.AddCurriculumStudies(request.School,request.LevelStudyIdSchool,request.CountryIdSchool,request.Init,request.Finish,request.CurrentlyStudyingHere,request.University
                ,request.Semester,request.LevelStudyIdUniversity,request.CountryIdUniversity,request.Id);

            this._repository.Update(curriculum);

            await this._repository.UnitOfWork.SaveEntitiesAsync();
            return true;
        }
    }
}
