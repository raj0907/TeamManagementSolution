using System.Threading.Tasks;
using TeamManagement.DTOs.BusinessUnit;

namespace TeamManagement.Business.BusinessUnit
{
    public interface IBusinessUnitBusinessLayer
    {
         Task<int> AddBusinessUnit(BusinessUnitRequest request);
         Task<int> UpdateBusinessUnit(BusinessUnitUpdateRequest request);
    }
}