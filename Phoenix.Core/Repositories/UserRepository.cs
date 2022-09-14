using Microsoft.Extensions.Configuration;
using Phoenix.Core.Models.DbModels;

namespace Phoenix.Core.Repositories
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public User InsertUser(User user)
        {
            return Insert(user);
        }

        public User? GetUserOrDefault(long Id)
        {
            return GetSingleOrDefault<User>(Id);
        }

        public IEnumerable<User> GetUsers()
        {
            return GetAll<User>();
        }

        public void DeleteUser(long Id)
        {
            Delete<User>(Id);
        }

        public IEnumerable<User> GetUsersByCreatedDate(DateTime date)
        {
            return GetAll<User>(where: "CAST([{nameof(User.CreatedDate)}] AS DATE) = @date");
        }
    }
}
