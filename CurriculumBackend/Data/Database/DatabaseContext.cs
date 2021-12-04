using Core.Rules;
using Data.Configurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Database
{
    public class DataBaseContext : DbContext, IUnitOfWork
    {
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;Database=CurriculumBackend2;User ID=root;Password=root");

                //optionsBuilder.UseMySQL("server=localhost;Database=CurriculumBackend;User ID=root;Password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("auth");
            base.OnModelCreating(modelBuilder);
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName("prof_" + entity.GetTableName());
            }

            modelBuilder.ApplyConfiguration(new CurriculumConfigurations());
         
        }

        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<CurriculumAbilities> CurriculumAbilities { get; set; }
        public DbSet<CurriculumAditionalInformation> CurriculumAditionalInformation { get; set; }
        public DbSet<CurriculumExperience> CurriculumExperiences { get; set; }
        public DbSet<CurriculumGeneral> CurriculumGenerals { get; set; }
        public DbSet<CurriculumIdiom> CurriculumIdioms { get; set; }
        public DbSet<CurriculumReference> CurriculumReferences { get; set; }
        public DbSet<CurriculumStudies> CurriculumStudies { get; set; }



        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            // After executing this line all the changes (from the Command Handler and Domain Event Handlers) 
            // performed through the DbContext will be committed
            var result = await base.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
