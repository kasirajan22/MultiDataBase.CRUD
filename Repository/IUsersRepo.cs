namespace MultiDataBase.CRUD;

public interface IUsersRepo
{
    public Task AddUser(Users user);
    public Task<Users?> GetUser(int id);
    public Task<List<Users>> GetAllUsers();
    public Users UpdateUser(Users user);
}
