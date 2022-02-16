using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using TeamManagement.Business.BusinessUnit;
using TeamManagement.DTOs.BusinessUnit;

namespace TeamManagement.Controllers
{
    [ApiController]
    [Route("api/BusinessUnit")]
    public class BusinessUnitController : ControllerBase
    {

        private readonly IBusinessUnitBusinessLayer _businessLayer;
        private readonly ILogger<BusinessUnitController> _logger;
        public BusinessUnitController(IBusinessUnitBusinessLayer businessLayer, ILogger<BusinessUnitController> logger)
        {
            _businessLayer = businessLayer;
            _logger = logger;
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add([FromBody]BusinessUnitRequest request)
        {          
           
            if (request == null)
            {
                return BadRequest();
            }
            try
            {
                var result = _businessLayer.AddBusinessUnit(request);
                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500, ex.Message);
            }           
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Update([FromBody] BusinessUnitUpdateRequest request)
        {
          
            if(request== null)
            {
                return BadRequest();
            }
            try
            {
                var result = _businessLayer.UpdateBusinessUnit(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500, ex.Message);
            }         

        }
    }
}
