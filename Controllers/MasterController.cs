using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using retroBackend.Business;
using retroBackend.Class;
using retroBackend.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace retroBackend.Controllers
{
    [Route("api/master")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        MasterBusiness _MasterBusiness = new MasterBusiness();

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string param)
        {
            try
            {
                if (!string.IsNullOrEmpty(param))
                {
                    var getValue = JsonConvert.DeserializeObject<string>(param);
                    var methodName = param[0];
                    switch (param)
                    {
                        case "GetData":
                            var data = _MasterBusiness.GetMasterData();
                            return Ok(data);
                        default:
                            return BadRequest("Invalid parameter.");
                    }
                }
                else
                {
                    return BadRequest("Parameter cannot be null or empty.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
