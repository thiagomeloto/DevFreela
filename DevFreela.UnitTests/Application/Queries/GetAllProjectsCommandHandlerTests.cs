using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetAllProjectsCommandHandlerTests
    {
        [Fact]
        public async Task ThreeprojectsExist_Executed_ReturnThreeProjectViewModels()
        {
            //Arrange: Onde são preparados os itens do teste. Ex: Criação de objetos.

            var projects = new List<Project>
            {
                new Project("Nome do Teste 1", "Descrição do Teste 1", 1, 2, 10000),
                new Project("Nome do Teste 2", "Descrição do Teste 2", 1, 2, 20000),
                new Project("Nome do Teste 3", "Descrição do Teste 3", 1, 2, 30000),
            };

            var projectRepositoryMock = new Mock<IProjectRepository>();
            projectRepositoryMock.Setup(pr => pr.GetAllAsync().Result).Returns(projects);

            var getAllProjectsQuery = new GetAllProjectsQuery("");
            var getAllProjectsQueryHandler = new GetAllProjectsQueryHandler(projectRepositoryMock.Object);

            //Act: Onde a ação a ser testada será executada.

            var projectViewModelList = await getAllProjectsQueryHandler.Handle(getAllProjectsQuery, new CancellationToken());

            //Assert: realiza verificações sobre o resultado final do teste.

            Assert.NotNull(projectViewModelList);
            Assert.NotEmpty(projectViewModelList);
            Assert.Equal(projects.Count, projectViewModelList.Count);

            //Garante que o método GetAllAsync seja chamado apenas uma vez.
            projectRepositoryMock.Verify(pr => pr.GetAllAsync().Result, Times.Once);
        }
    }
}
