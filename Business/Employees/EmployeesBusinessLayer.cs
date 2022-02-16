using System.Collections.Generic;
using TeamManagement.DTOs.Employees;
using TeamManagement.Respositories.Employees;

namespace TeamManagement.Business.Employees
{
    public class EmployeesBusinessLayer : IEmployeesBusinessLayer
    {
        private readonly IEmployeesServices _employeesServices;
        public EmployeesBusinessLayer(IEmployeesServices employeesServices)
        {
            _employeesServices = employeesServices;
        }
        public List<EmployeesResponse> SearchEmployee(EmployeeSearchRequest request)
        {
            return _employeesServices.SearchEmployee(request);
        }
    }
}
