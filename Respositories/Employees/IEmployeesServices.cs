using System.Collections.Generic;
using TeamManagement.DTOs.Employees;

namespace TeamManagement.Respositories.Employees
{
    public interface IEmployeesServices
    {
        List<EmployeesResponse> SearchEmployee(EmployeeSearchRequest request); 
    }
}
