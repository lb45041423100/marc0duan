using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SubscribeManager;
namespace V2rayConverter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class V2rayConverterController : ControllerBase
    {
        

        private readonly ILogger<V2rayConverterController> _logger;

        public V2rayConverterController(ILogger<V2rayConverterController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            try
            {
                var url = Request.Query["url"];
                var convertUrl = new ConvertUrl(url);
                return convertUrl.result;
            }
            catch
            {
                throw new Exception("arg error");
            }
            
            
        }
    }
}
