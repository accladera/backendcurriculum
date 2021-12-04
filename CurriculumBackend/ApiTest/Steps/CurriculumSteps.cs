using TechTalk.SpecFlow;
using Data.Database;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;


namespace ApiTest.Spec.Steps
{
    public class CurriculumSteps
    {
       

        [Fact]
        public void CreateCurriculum()
        {
            Curriculum cur = new Curriculum(1, "Juan", "Perez", "3123213", 1);

            Assert.True(cur != null, "Fue añadido correctamente");
        }

      
    }
}
