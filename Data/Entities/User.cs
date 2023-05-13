using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class User
    {
        [Required]
        [Key]
        public Guid IdUser { get; set; }
        public string UserName { get; set; }
        public string ConnectionString { get; set; }
        public DateTime? LastUpdate { get; set; }
        public ICollection<Relation> Relations { get; set; }
    }
}