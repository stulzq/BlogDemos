using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;

namespace DotNetCoreUseJs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly INodeServices _services;

        public ValuesController(INodeServices services)
        {
            _services = services;
        }
        // GET api/values
        [HttpGet]
        public async Task<string> Get()
        {
            
            string greetingMessage = await _services.InvokeAsync<string>("./scripts/greeter", "晓晨");
            return greetingMessage;
        }
    }
}
