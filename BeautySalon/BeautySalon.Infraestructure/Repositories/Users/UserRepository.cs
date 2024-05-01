using BeautySalon.Domain.Entities;
using BeautySalon.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BeautySalon.Infraestructure.Repositories.Users;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;    
    }

    public async Task<List<User>> GetAllUsersAsync(bool asnotracking = false)
    {
        return asnotracking? await _context.Users.AsNoTracking().ToListAsync() : await _context.Users.ToListAsync(); 
    }

    public Task<User> GetByIdAsync(int id, bool asnotracking)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserByEmailAsync(string email, bool asnotracking)
    {
        throw new NotImplementedException();
    }

    public async Task<User> InsertUserAsync(User user)
    {
        await _context.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public void RemoveUser(User user, bool asnotracking)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateUserAsync(User user, bool asnotracking)
    {
        throw new NotImplementedException();
    }
}