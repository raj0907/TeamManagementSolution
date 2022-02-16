using AutoMapper;
using TeamManagement.Context;
using TeamManagement.DTOs.BusinessUnitMemebers;
using TeamManagement.Models;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace TeamManagement.Respositories.BusinessUnitMemebers
{
    public class BusinessUnitMemebersServices : IBusinessUnitMemebersServices
    {
        private readonly TeamManagementDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public BusinessUnitMemebersServices(TeamManagementDbContext dbContext, IMapper mapper, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _configuration = configuration;
        }
        public void AttachBusinessUnit(BusinessUnitMemebersRequest request)
        {
            var map = _mapper.Map<Models.BusinessUnitMemebers>(request);
            var temp = _dbContext.BusinessUnitMemebers.Attach(map);
            temp.State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _dbContext.SaveChangesAsync();
        }

        public void DetachBusinessUnit(BusinessUnitMemebersRequest request)
        {
            var map = _mapper.Map<Models.BusinessUnitMemebers>(request);

            var Employee = _dbContext.BusinessUnitMemebers.Where(a => a.EmployeeLoginId == map.EmployeeLoginId).FirstOrDefault();
            if(Employee != null )
            {
                var IsManager = Employee.IsManager;
                if(!IsManager)
                {
                    var temp = _dbContext.BusinessUnitMemebers.Attach(map);
                    temp.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                    _dbContext.SaveChangesAsync();
                }
                else
                {                    
                    throw new System.Exception(_configuration.GetSection("BUDetachRuleMessage").Value);
                }
            }
          
        }
    }
}
