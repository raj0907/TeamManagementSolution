using TeamManagement.DTOs.BusinessUnitMemebers;

namespace TeamManagement.Business.BusinessUnitMemebers
{
    public interface IBusinessUnitMemebersBusinessLayer
    {
        void AttachBusinessUnit(BusinessUnitMemebersRequest request);
        void DetachBusinessUnit(BusinessUnitMemebersRequest request);
    }
}
