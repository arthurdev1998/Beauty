using BeautySalon.Domain.Entities;

namespace BeautySalon.Infraestructure.Repositories.Users;

public interface IUserRepository
{
    public Task<List<User>> GetAllUsersAsync(bool asnotracking);
    public Task<User> GetByIdAsync(int id, bool asnotracking);
    public Task<User> GetUserByEmailAsync(string email, bool asnotracking);
    public Task<User> InsertUserAsync(User user);
    public Task<User> UpdateUserAsync(User user, bool asnotracking);
    public void RemoveUser(User user, bool asnotracking);
}