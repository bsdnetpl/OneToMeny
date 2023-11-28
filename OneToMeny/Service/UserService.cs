using OneToMeny.DBSConnect;
using OneToMeny.Model;

namespace OneToMeny.Service
{
    public class UserService : IUserService
    {
        private readonly ConnectToMssql _connectToMssql;

        public UserService(ConnectToMssql connectToMssql)
        {
            _connectToMssql = connectToMssql;
        }
        public async Task<Users> AddUserAsync(Users users)
        {
            await _connectToMssql.UsersDB.AddAsync(users);
            await _connectToMssql.SaveChangesAsync();
            return users;

        }
    }
}
