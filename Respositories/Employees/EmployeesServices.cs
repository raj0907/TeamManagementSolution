using AutoMapper;
using TeamManagement.Context;
using TeamManagement.DTOs.Employees;
using TeamManagement.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TeamManagement.Respositories.Employees
{
    public class EmployeesServices : IEmployeesServices
    {
        private readonly TeamManagementDbContext _dbContext;
        private readonly IMapper _mapper;

        public EmployeesServices(TeamManagementDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;  
        }
        public List<EmployeesResponse> SearchEmployee(EmployeeSearchRequest request)
        {
            var map = _mapper.Map<Employee>(request);

            var temp = _dbContext.Employees.Where
                            (
                                a => a.FirstName == map.FirstName ||
                                a.LastName == map.LastName ||
                                a.EmailAddress == map.EmailAddress
                            ).ToList();

            return _mapper.Map<List<EmployeesResponse>>(temp);
        }
    }
}
