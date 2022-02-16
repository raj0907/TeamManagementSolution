using TeamManagement.DTOs.BusinessUnitMemebers;

namespace TeamManagement.Respositories.BusinessUnitMemebers
{
    public interface IBusinessUnitMemebersServices
    {
        void AttachBusinessUnit(BusinessUnitMemebersRequest request);
        void DetachBusinessUnit(BusinessUnitMemebersRequest request);
    }
}
