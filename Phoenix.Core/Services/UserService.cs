using Phoenix.Core.Models.DbModels;
using Phoenix.Core.Models.Requests;
using Phoenix.Core.Repositories;

namespace Phoenix.Core.Services
{
    public class UserService
    {
        private readonly UserRepository userRepository;

        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void CreateUser(CreateUserRequest userRequest)
        {
            var user = new User()
            {
                FirstName = userRequest.FirstName,
                LastName = userRequest.LastName,
                Birthdate = userRequest.Birthdate,
                RoleId = userRequest.RoleId,
                CreatedDate = DateTime.Now,
            };

            userRepository.InsertUser(user);
        }

        public User? GetUser(long Id)
        {
            return userRepository.GetUserOrDefault(Id);
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public void DeleteUser(long Id)
        {
            userRepository.DeleteUser(Id);
        }

        public IEnumerable<User> GetUsersByCreatedDate(DateTime date)
        {
            return userRepository.GetUsersByCreatedDate(date);
        }
    }
}
