using EmployeeDatabase.DAL.Entities;

namespace EmployeeDatabase.BLL.Interfaces
{
    public interface IUserService
    {
        Task<int> CreateUserAsync(User user);
        Task<IReadOnlyCollection<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> UpdateUserAsync(int id, User user);
    }
}
