using DevFreela.Core.Entities;
using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTests.Core.Entities
{
    public class ProjectTests
    {
        [Fact]
        public void TestIfProjectStartWorks()
        {
            var project = new Project("Nome de Teste", "Descrição de Teste", 1, 2, 10000);

            //Verificação se o primeiro status do projeto é Created.
            Assert.Equal(ProjectStatusEnum.Created, project.Status);

            //Verificação se antes do projeto iniciar, a data de início está vazia.
            Assert.Null(project.StartedAt);

            Assert.NotNull(project.Title);
            Assert.NotEmpty(project.Title);

            Assert.NotNull(project.Description);
            Assert.NotEmpty(project.Description);

            project.Start();

            //Verificação se após o projeto iniciar, o status mudou de Created para InProgress.
            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);

            //Verificação se a data de início do projeto não é nula.
            Assert.NotNull(project.StartedAt);
        }
    }
}
