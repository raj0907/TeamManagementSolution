using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TeamManagement.Models
{
    [Table("BusinessUnitCategories")]
    public class BusinessUnitCategories
    {

        [Column("BUC_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("BU_ID")]
        [Required]
        [ForeignKey("BU_ID")]
        public virtual int BusinessUnitId { get; set; }
        public virtual BusinessUnit BusinessUnit { get; set; }


        [Column("ZURICH_LINE_OF_BUSINESS", TypeName = "char(50)")]
        [Required]
        public string ZurichLineOfBusiness { get; set; }      
    }
}
