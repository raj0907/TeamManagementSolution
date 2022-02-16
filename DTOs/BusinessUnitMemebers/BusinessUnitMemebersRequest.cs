namespace TeamManagement.DTOs.BusinessUnitMemebers
{
    public class BusinessUnitMemebersRequest
    {       
        public string EmployeeLoginId { get; set; }      
        public bool IsManager { get; set; }
        public int BusinessUnitId { get; set; }
    }
}
