using Microsoft.EntityFrameworkCore;
using OneToMeny.DBSConnect;
using OneToMeny.Model;
using System.Data.SqlTypes;

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
        public Users GetUserByName(string name)
        {

            var getUser = _connectToMssql.UsersDB
                .Include(i => i.roles)
                .Where(f => f.name == name)
                .ToList()
                .FirstOrDefault();
            return getUser;

        }
        public async Task<bool> DeleteUser(string name)
        {
            var getUser = _connectToMssql.UsersDB
                   .Include(i => i.roles)
                   .Where(f => f.name == name)
                   .ToList()
                   .FirstOrDefault();
            _connectToMssql.UsersDB.Remove(getUser);
            await _connectToMssql.SaveChangesAsync();
            return true;
        }

    }
}
