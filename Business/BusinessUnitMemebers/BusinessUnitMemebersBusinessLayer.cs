using TeamManagement.DTOs.BusinessUnitMemebers;
using TeamManagement.Respositories.BusinessUnitMemebers;
namespace TeamManagement.Business.BusinessUnitMemebers
{
    
    public class BusinessUnitMemebersBusinessLayer: IBusinessUnitMemebersBusinessLayer
    {
        private readonly IBusinessUnitMemebersServices _businessUnitMemebersServices;

        public BusinessUnitMemebersBusinessLayer(IBusinessUnitMemebersServices businessUnitMemebersServices)
        {
            _businessUnitMemebersServices = businessUnitMemebersServices;   
        }
        public void AttachBusinessUnit(BusinessUnitMemebersRequest request)
        {
            _businessUnitMemebersServices.AttachBusinessUnit(request);
        }
        public void DetachBusinessUnit(BusinessUnitMemebersRequest request)
        {
            _businessUnitMemebersServices.DetachBusinessUnit(request);
        }
    }
}
