using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Table
    {
        [Required]
        [Key]
        public int IdTable { get; set; }
        public string TableName { get; set; }
        public ICollection<Relation> Relations { get; set; }
    }
}