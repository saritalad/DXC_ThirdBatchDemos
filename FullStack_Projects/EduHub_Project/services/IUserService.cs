using EduHub_Project.Models;

namespace EduHub_Project.services
{
    public interface IUserService
    {
        Task<User> GetUserAsync(int userId);
        Task<IEnumerable<User>> GetAllStudentsAsync();
        Task<User> CreateUserAsync(User newUser);
        Task<User> UpdateUserAsync(int userId, User updatedUser);
        Task<bool> DeleteUserAsync(int userId);
    }
}
