using Core.Rules;
using Data.Database;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.CurriculumRepository
{
    public class CurriculumRepository : BaseRepository<Curriculum>, ICurriculumRepository
    {
        public CurriculumRepository(DataBaseContext context) : base(context)
        {
        }

        public IUnitOfWork UnitOfWork => _context;

        public Curriculum Add(Curriculum entity)
        {
            return AddAux(entity);
        }

      
        public Curriculum Update(Curriculum entity)
        {
            return UpdateAux(entity);
        }

        public async Task<Curriculum> getCurriculum(int id)
        {
            return await _context.Curriculums.Where(ele => ele.Id == id)
                .Include(x => x.CurAbilities)
                 .Include(x => x.CurAdionalInformations)
                  .Include(x => x.CurExperiences)
                   .Include(x => x.CurGenerals)
                    .Include(x => x.CurIdiomes)
                     .Include(x => x.CurReferences)
                      .Include(x => x.CurStudies)
                    
                .FirstOrDefaultAsync();
        }

        public async Task<List<Curriculum>> getListCurriculumByUser(int userId)
        {
            return await _context.Curriculums.Where(ele => ele.ClientId == userId).ToListAsync();
        }

        public async Task<bool> Delete(int IdCurriculum)
        {
            Curriculum objCurriculum = await getCurriculum(IdCurriculum);
               
            if(objCurriculum != null)
            {
                 DeleteAux(objCurriculum);
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}