using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManagement.Models
{
    [Table("BusinessUnitMemebers")]
    public class BusinessUnitMemebers
    {
        [Column("BUM_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessUnitMemebersId { get; set; }

        [Column("BU_ID")]
        [Required]
        [ForeignKey("BU_ID")]
        public virtual int BusinessUnitId { get; set; }
        public virtual BusinessUnit BusinessUnit { get; set; }

        [Column("EMPLOYEE_LOGIN_ID", TypeName = "char(100)")]
        [Required]
        public virtual string EmployeeLoginId { get; set; }

        [Column("IS_MANAGER")]
        [Required]
        public bool IsManager { get; set; }
    }
}
