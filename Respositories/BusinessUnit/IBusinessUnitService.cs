using System.Threading.Tasks;
using TeamManagement.DTOs.BusinessUnit;

namespace TeamManagement.Respositories
{
    public interface IBusinessUnitService
    {
        public Task<int> AddBusinessUnit(BusinessUnitRequest request);
        public Task<int> UpdateBusinessUnit(BusinessUnitUpdateRequest request);
    }
}