
using Microsoft.EntityFrameworkCore;

namespace MultiDataBase.CRUD;

public class UserRepo : IUsersRepo
{
    protected readonly UserDBContext _dBContext;

    public UserRepo(UserDBContext dBContext)
    {
        this._dBContext = dBContext;
    }
    public async Task AddUser(Users user)
    {
       await _dBContext.Users.AddAsync(user);
       await _dBContext.SaveChangesAsync();
    }
    public async Task<List<Users>> GetAllUsers()
    {
        return await _dBContext.Users.ToListAsync();
    }
    public async Task<Users?> GetUser(int id)
    {
        return await _dBContext.Users.Where(u => u.Id.Equals(id)).FirstOrDefaultAsync();
    }
    public Users UpdateUser(Users user)
    {
        _dBContext.Users.Update(user);
        return user;
    }
}
