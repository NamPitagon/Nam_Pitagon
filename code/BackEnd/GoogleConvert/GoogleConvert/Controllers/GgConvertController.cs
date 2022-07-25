using GoogleConvert.Dto;
using GoogleConvert.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GoogleConvert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GgConvertController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public GgConvertController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IGgConvert googleConvert = new GgConvert(new ConvertShare());

        [HttpPost("convert")]
        public ResponseData ggConvertData(string inputType, string outputType, string inputValue)
        {
            return googleConvert.ggConvertData(inputType, outputType, inputValue);
        }
        //[HttpPost("StringToBase64")]
        //public ResponseData StringToBase64(string inputValue)
        //{
        //    return googleConvert.StringToBase64(inputValue);
        //}

        //[HttpPost("StringToArrByte")]
        //public ResponseData StringToArrByte(string inputValue)
        //{
        //    return googleConvert.StringToArrByte(inputValue);
        //}

        //[HttpPost("StringToHex")]
        //public ResponseData StringToHex(string inputValue)
        //{
        //    return googleConvert.StringToHex(inputValue);
        //}

        //[HttpPost("ArrByteToBase64")]
        //public ResponseData ArrByteToBase64(string inputValue)
        //{
        //    return googleConvert.ArrByteToBase64(inputValue);
        //}

        //[HttpPost("ArrByteToHex")]
        //public ResponseData ArrByteToHex(string inputValue)
        //{
        //    return googleConvert.ArrByteToHex(inputValue);
        //}

        //[HttpPost("ArrByteToString")]
        //public ResponseData ArrByteToString(string inputValue)
        //{
        //    return googleConvert.ArrByteToString(inputValue);
        //}

        //[HttpPost("Base64ToArrByte")]
        //public ResponseData Base64ToArrByte(string inputValue)
        //{
        //    return googleConvert.Base64ToArrByte(inputValue);
        //}

        //[HttpPost("Base64ToHex")]
        //public ResponseData Base64ToHex(string inputValue)
        //{
        //    return googleConvert.Base64ToHex(inputValue);
        //}

        //[HttpPost("Base64ToString")]
        //public ResponseData Base64ToString(string inputValue)
        //{
        //    return googleConvert.Base64ToString(inputValue);
        //}

        //[HttpPost("HexToArrByte")]
        //public ResponseData HexToArrByte(string inputValue)
        //{
        //    return googleConvert.HexToArrByte(inputValue);
        //}

        //[HttpPost("HexToBase64")]
        //public ResponseData HexToBase64(string inputValue)
        //{
        //    return googleConvert.HexToBase64(inputValue);
        //}

        //[HttpPost("HexToString")]
        //public ResponseData HexToString(string inputValue)
        //{
        //    return googleConvert.HexToString(inputValue);
        //}
    }
}
