using DevFreela.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetProjectByIdAsync(int id);
        Task<int> AddASync(Project project);
        Task DeleteAsync(int id);
        Task FinishAsync(int id);
        Task StartAsync(int id);
        Task UpdateAsync(Project project);
        Task AddCommentAsync(ProjectComment projectComment);
        Task SaveChangesAsync();
    }
}
