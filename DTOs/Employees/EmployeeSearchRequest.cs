using System.ComponentModel.DataAnnotations;

namespace TeamManagement.DTOs.Employees
{
    public class EmployeeSearchRequest
    {      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
