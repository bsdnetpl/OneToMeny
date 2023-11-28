using OneToMeny.Model;

namespace OneToMeny.Service
{
    public interface IUserService
    {
        Task<Users> AddUserAsync(Users users);
    }
}