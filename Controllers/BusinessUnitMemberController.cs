using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using TeamManagement.Business.BusinessUnitMemebers;
using TeamManagement.DTOs.BusinessUnitMemebers;

namespace TeamManagement.Controllers
{
    [ApiController]
    [Route("api/BusinessUnitMemebers")]
    public class BusinessUnitMemberController : ControllerBase
    {
        private readonly IBusinessUnitMemebersBusinessLayer _businessLayer;
        private readonly ILogger<BusinessUnitMemberController> _logger;

        public BusinessUnitMemberController(IBusinessUnitMemebersBusinessLayer businessUnitMemebersBusinessLayer, ILogger<BusinessUnitMemberController> logger)
        {
            _businessLayer = businessUnitMemebersBusinessLayer;
            _logger = logger;
        }
        [HttpPatch]
        [Route("Attach")]
        public IActionResult Update([FromBody] BusinessUnitMemebersRequest request)
        {
            if(request == null)
            {
                return BadRequest();
            }
            try
            {
                _businessLayer.AttachBusinessUnit(request);
                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPatch]
        [Route("Detach")]
        public IActionResult Detach([FromBody] BusinessUnitMemebersRequest request)
        {
            try
            {
                _businessLayer.DetachBusinessUnit(request);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
