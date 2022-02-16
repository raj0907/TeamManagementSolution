using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManagement.Models
{
    [Table("BusinessUnit")]
    public class BusinessUnit
    {
        [Key]
        [Column("BU_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("BU_NAME", TypeName ="CHAR(50)")]
        [Required]
        public string Name { get; set; }

        [Column("BU_DESCRIPTION", TypeName = "CHAR(500)")]
        [Required]
        public string Description { get; set; }

        [Column("ACTIVITY")]
        [Required]
        public bool Activity { get; set; }

        [Column("BU_TYPE", TypeName = "CHAR(4)")]
        [Required]
        public string Type { get; set; }

    }
}
