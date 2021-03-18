using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloEmpty.Models;

namespace HelloEmpty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<HelloMessage> Get()
        {
            List<HelloMessage> messages = new List<HelloMessage>();
            messages.Add(new HelloMessage() { Message = "Hello Web API1" });
            messages.Add(new HelloMessage() { Message = "Hello Web API2" });
            messages.Add(new HelloMessage() { Message = "Hello Web API3" });

            return messages;
        }
    }
}
