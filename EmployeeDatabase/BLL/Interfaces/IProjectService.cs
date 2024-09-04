using EmployeeDatabase.DAL.Entities;

namespace EmployeeDatabase.BLL.Interfaces
{
    public interface IProjectService
    {
        Task<int> CreateProjectAsync(Project project);
        Task<IReadOnlyCollection<Project>> GetProjectsAsync();
        Task<Project> UpdateProjectAsync(int id, Project project);
    }
}
