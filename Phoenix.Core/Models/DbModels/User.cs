using System.ComponentModel.DataAnnotations.Schema;

namespace Phoenix.Core.Models.DbModels
{
    [Table("User", Schema = "dbo")]
    public class User
    {
        [Column]
        public long Id { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column]
        public string LastName { get; set; }

        [Column]
        public DateTime Birthdate { get; set; }

        [Column]
        public long RoleId { get; set; }

        [Column]
        public DateTime CreatedDate { get; set; }
    }
}
