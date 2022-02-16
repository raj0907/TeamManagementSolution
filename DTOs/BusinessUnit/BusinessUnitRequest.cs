using System.ComponentModel.DataAnnotations;
namespace TeamManagement.DTOs.BusinessUnit
{
    public class BusinessUnitRequest
    {  
        [Required]
        [StringLength(50, MinimumLength =2, ErrorMessage ="Max Length 50 , Min Length 2, Mandatory") ]
        public string Name { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Max Length 500 , Min Length 1, Mandatory")]        
        public string Description { get; set; }

        [Required]        
        public bool Activity { get; set; }

        [Required]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Max Length 4 , Min Length 1, Mandatory")]
        public string Type { get; set; }
    }

    public class BusinessUnitUpdateRequest: BusinessUnitRequest
    {
        public int Id { get; set; }
    }
}
