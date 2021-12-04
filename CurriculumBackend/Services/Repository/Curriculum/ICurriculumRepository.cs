using Core.Repository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.CurriculumRepository
{
    public interface ICurriculumRepository : IRepository<Curriculum>
    {
        Task<Curriculum> getCurriculum(int id);
        Task<List<Curriculum>> getListCurriculumByUser(int userId);

        Task<bool> Delete(int curriculumId);

    }
}
