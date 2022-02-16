

using AutoMapper;
using System;
using System.Threading.Tasks;
using TeamManagement.Context;
using TeamManagement.DTOs.BusinessUnit;
using TeamManagement.Models;

namespace TeamManagement.Respositories
{

    public class BusinessUnitService : IBusinessUnitService
    {
        private readonly TeamManagementDbContext _dbContext;
        private readonly IMapper _mapper;

        public BusinessUnitService(TeamManagementDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<int> AddBusinessUnit(BusinessUnitRequest request)
        {           
            var map = _mapper.Map<BusinessUnit>(request);
            await _dbContext.BusinessUnits.AddAsync(map);
            return await _dbContext.SaveChangesAsync();          
        }

        public async Task<int> UpdateBusinessUnit(BusinessUnitUpdateRequest request)
        {
            var map = _mapper.Map<BusinessUnit>(request);
            _dbContext.BusinessUnits.Update(map);
            return await _dbContext.SaveChangesAsync();
          
        }
    }
}
