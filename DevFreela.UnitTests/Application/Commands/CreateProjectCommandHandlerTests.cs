using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTests.Application.Commands
{
    public class CreateProjectCommandHandlerTests
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnProjectId()
        {
            //Arrange: Onde são preparados os itens do teste. Ex: Criação de objetos.

            var projectRepository = new Mock<IProjectRepository>();

            var createProjectCommand = new CreateProjectCommand
            {
                Title = "Titulo de Teste",
                Description = "Descrição de Teste",
                TotalCost = 10000,
                IdClient = 1,
                IdFreelancer = 2
            };

            var createProjectCommandHandler = new CreateProjectCommandHandler(projectRepository.Object);

            //Act: Onde a ação a ser testada será executada.

            var id = await createProjectCommandHandler.Handle(createProjectCommand, new CancellationToken());

            //Assert: realiza verificações sobre o resultado final do teste.

            Assert.True(id >= 0); //valida se o id de retorno é maior ou igual a zero. se retorna -1 o projeto não foi criado.

            //Verifica se o método addAsync foi chamado somente uma vez. O IsAny significa que tanto faz o projeto que tenha sido passado por parâmetro.
            projectRepository.Verify(pr => pr.AddASync(It.IsAny<Project>()), Times.Once);
        }
    }
}
