using Application.bookshelf.Core;
using Application.bookshelf.Infractructure;
using System.Threading.Tasks;
using Dapper;

namespace Application.bookshelf.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly BookShelfDbContext _context;

        #region SQLQueries
        private readonly string varifyUser = @"Select id, fullname, emailaddress, password, role 
                                              from Users 
                                              where emailaddress = @EmailAddress AND password = @Password";
        #endregion

        public UserRepo(BookShelfDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserbyUserNameAndPassword(string email, string password)
        {
            using (var connection = _context.CreateConnection())
            {
                var userdata = await connection.QueryFirstOrDefaultAsync<User>(varifyUser, new { EmailAddress = email, Password = password });

                return userdata; // Return the found user or null if not found
            }
        }
    }
}
