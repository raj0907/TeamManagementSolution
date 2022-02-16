using TeamManagement.Models;

namespace TeamManagement.DTOs.Employees
{
    public class EmployeesResponse
    {       
        public string Id { get; set; }     
        public string FirstName { get; set; }      
        public string LastName { get; set; }        
        public string Status { get; set; }       
        public string EmailAddress { get; set; }
    }
}
