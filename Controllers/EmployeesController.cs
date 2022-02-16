using Microsoft.AspNetCore.Mvc;
using TeamManagement.Business.Employees;
using TeamManagement.DTOs.Employees;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Logging;

namespace TeamManagement.Controllers
{
    [ApiController]
    [Route("api/Employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesBusinessLayer _businessLayer;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(IEmployeesBusinessLayer employeesBusinessLayer, ILogger<EmployeesController> logger)
        {
            _businessLayer = employeesBusinessLayer;
            _logger = logger;
        }

        [HttpGet]
        [Route("Search")]
        public List<EmployeesResponse> Get(EmployeeSearchRequest request)
        {
            if(request == null)
            {
                return new List<EmployeesResponse>();
            }
            try
            {
                return _businessLayer.SearchEmployee(request);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex,ex.Message);
                return new List<EmployeesResponse>();
            }
        }
    }
}
