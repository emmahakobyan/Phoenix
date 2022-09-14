namespace Phoenix.Core.Models.Requests
{
    public class CreateUserRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public long RoleId { get; set; }
    }
}
