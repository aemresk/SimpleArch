using System.ComponentModel.DataAnnotations.Schema;

namespace Zandeross.Domain
{
    [Table("Personal")]
   public class Personal  :BaseDataEntities
    {
        [Column("Name")]
        public string Name { get; set; }
        [Column("Lastname")]
        public string Lastname { get; set; }
    }
}
