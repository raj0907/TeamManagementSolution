
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManagement.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Column("EMP_LOGIN_ID")]
        [Key]
        public string EmployeeLoginId { get; set; }

        [Column("BU_ID")]
        [Required]
        [ForeignKey("BU_ID")]
        public virtual int BusinessUnitId { get; set; }
        public virtual BusinessUnit BusinessUnit { get; set; }

        [Column("FIRST_NAME", TypeName = "char(50)")]
        [Required]
        public string FirstName { get; set; }

        [Column("LAST_NAME", TypeName = "char(50)")]
        [Required]
        public string LastName { get; set; }

        [Column("STATUS", TypeName = "char(3)")]
        [Required]
        public string Status { get; set; }

        [Column("EMAIL_ADDRESS", TypeName = "char(300)")]
        [Required]
        public string EmailAddress { get; set; }
    }
}
