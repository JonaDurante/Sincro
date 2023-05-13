using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Relation
    {
        [ForeignKey("User")]
        public Guid IdUser { get; set; }
        public User User { get; set; }

        [ForeignKey("Table")]
        public int IdTable { get; set; }
        public Table Table { get; set; }
    }
}
