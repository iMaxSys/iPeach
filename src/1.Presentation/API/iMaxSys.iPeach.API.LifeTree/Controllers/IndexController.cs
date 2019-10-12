using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace iMaxSys.iPeach.Launcher.Manx.Controllers
{
    /// <summary>
    /// IndexController Class
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class IndexController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return $"it's time: {DateTime.Now}";


        }
    }
}
