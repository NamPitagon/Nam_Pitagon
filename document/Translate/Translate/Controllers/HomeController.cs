using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Translate.Models;

namespace Translate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
     
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IInputData inputData = new Adapter(new OutputData());

        [HttpPost("ConvertFromStringToByte")]
        public ActionResult<string> ConvertFromStringToByte(string input)
        {
            return inputData.SendRequestStringToByte(input);
        }

        [HttpPost("ConvertFromByteToString")]
        public ActionResult<string> ConvertFromByteToString(string input)
        {
            return inputData.SendRequestByteToString(input);
        }

        [HttpPost("ConvertFromStringToBase64")]
        public ActionResult<string> ConvertFromStringToBase64(string input)
        {
            return inputData.SendRequestStringToBase64(input);
        }
        [HttpPost("ConvertFromStringToHex")]
        public ActionResult<string> ConverFromStringToHex(string input)
        {
            return inputData.SendRequestStringToHex(input);
        }
        [HttpPost("ConvertFromHexToString")]
        public ActionResult<string> ConverFromHexToString(string input)
        {
            return inputData.SendRequestHexToString(input);
        }

        [HttpPost("ConvertFromBase64ToString")]
        public ActionResult<string> ConvertFromBase64ToString(string input)
        {
            return inputData.SendRequestBase64ToString(input);
        }

        [HttpPost("ConvertFromHexToByte")]
        public ActionResult<string> ConvertFromHexToByte(string input)
        {
            return inputData.SendRequestHexToByte(input);
        }

        [HttpPost("ConvertFromBase64ToByte")]
        public ActionResult<string> ConvertFromBase64ToByte(string input)
        {
            return inputData.SendRequestBase64ToByte(input);
        }
        [HttpPost("ConvertFromByteToBase64")]
        public ActionResult<string> ConvertFromByteToBase64(string input)
        {
            return inputData.SendRequestByteToBase64(input);
        }

        [HttpPost("ConvertFromByteToHex")]
        public ActionResult<string> ConvertFromByteToHex(string input)
        {
            return inputData.SendRequestByteToHex(input);
        }

        [HttpPost("ConvertFromHexToBase64")]
        public ActionResult<string> ConvertFromHexToBase64(string input)
        {
            return inputData.SendRequestHexToBase64(input);
        }
        [HttpPost("ConvertFromBase64ToHex")]
        public ActionResult<string> ConvertFromBase64ToHex(string input)
        {
            return inputData.SendRequestBase64ToHex(input);
        }
    }
}
