using System.Threading.Tasks;
using TeamManagement.DTOs.BusinessUnit;
using TeamManagement.Respositories;

namespace TeamManagement.Business.BusinessUnit
{
    public class BusinessUnitBusinessLayer : IBusinessUnitBusinessLayer
    {
        private readonly IBusinessUnitService _businessUnitService;
        public BusinessUnitBusinessLayer(IBusinessUnitService businessUnitService)
        {
            _businessUnitService = businessUnitService;
        }

        public async Task<int> AddBusinessUnit(BusinessUnitRequest request)
        {
            return await _businessUnitService.AddBusinessUnit(request);
        }

        public async Task<int> UpdateBusinessUnit(BusinessUnitUpdateRequest request)
        {
            return await _businessUnitService.UpdateBusinessUnit(request); 
        }
    }
}
