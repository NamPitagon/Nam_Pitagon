using GoogleConvert.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GoogleConvert.Controllers
{
    [Route("api/[controller]")] // sử dụng attribute routing

    // class ConvertController được đánh dấu với attribute [ApiController]
    // kế thừa từ ControllerBase thay vì Controller như bình thường
    [ApiController]
    public class ConvertController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ConvertController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConvertType convertType = new ConvertType(new ConvertDataToArrayByte());

        [HttpPost("StringToBase64")]
        public ActionResult<string> ConvertStringToBase64(string str)
        {
            return convertType.ConvertStringToBase64(str);
        }
        [HttpPost("ArrayByteToBase64")]
        public ActionResult<string> ConvertArrayByteToBase64(string strArrayByte)
        {
            return convertType.ConvertArrayByteToBase64(strArrayByte);
        }
        [HttpPost("ArrayByteToHex")]
        public ActionResult<string> ConvertArrayByteToHex(string strArrayByte)
        {
            return convertType.ConvertArrayByteToHex(strArrayByte);
        }
        [HttpPost("ArrayByteToString")]
        public ActionResult<string> ConvertArrayByteToString(string strArrayByte)
        {
            return convertType.ConvertArrayByteToString(strArrayByte);
        }
        [HttpPost("Base64ToArrayByte")]
        public ActionResult<string> ConvertBase64ToArrayByte(string strBase64)
        {
            return convertType.ConvertBase64ToArrayByte(strBase64);
        }
        [HttpPost("Base64ToHex")]
        public ActionResult<string> ConvertBase64ToHex(string strBase64)
        {
            return convertType.ConvertBase64ToHex(strBase64);
        }
        [HttpPost("Base64ToString")]
        public ActionResult<string> ConvertBase64ToString(string strBase64)
        {
            return convertType.ConvertBase64ToString(strBase64);
        }
        [HttpPost("HexToArrayByte")]
        public ActionResult<string> ConvertHexToArrayByte(string strHex)
        {
            return convertType.ConvertHexToArrayByte(strHex);
        }
        [HttpPost("HexToBase64")]
        public ActionResult<string> ConvertHexToBase64(string strHex)
        {
            return convertType.ConvertHexToBase64(strHex);
        }
        [HttpPost("HexToString")]
        public ActionResult<string> ConvertHexToString(string strHex)
        {
            return convertType.ConvertHexToString(strHex);
        }
        [HttpPost("StringToArrayByte")]
        public ActionResult<string> ConvertStringToArrayByte(string str)
        {
            return convertType.ConvertStringToArrayByte(str);
        }
        [HttpPost("StringToHex")]
        public ActionResult<string> ConvertStringToHex(string str)
        {
            return convertType.ConvertStringToHex(str);
        }
    }
}
