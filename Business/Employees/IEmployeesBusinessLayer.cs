using System.Collections.Generic;
using TeamManagement.DTOs.Employees;

namespace TeamManagement.Business.Employees
{
    public interface IEmployeesBusinessLayer
    {
        List<EmployeesResponse> SearchEmployee(EmployeeSearchRequest request);
    }
}
