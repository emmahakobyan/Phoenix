using System.ComponentModel.DataAnnotations.Schema;

namespace Phoenix.Core.Models.DbModels
{
    [Table("Role", Schema = "dbo")]
    public class Role
    {
        [Column]
        public long Id { get; set; }

        [Column]
        public string Name { get; set; }
    }
}
