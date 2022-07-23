using GoogleConvert.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoogleConvert.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class GoogleConvertController : ControllerBase
    {
        public IGgConvert googleConvert = new GgConvert(new ConvertShare());

        [HttpPost("StringToBase64")]
        public ActionResult<string> ConvertStringToBase64(string str)
        {
            return googleConvert.ConvertStringToBase64(str);
        }
        [HttpPost("ArrayByteToBase64")]
        public ActionResult<string> ConvertArrayByteToBase64(string strArrayByte)
        {
            return googleConvert.ConvertArrayByteToBase64(strArrayByte);
        }
        [HttpPost("ArrayByteToHex")]
        public ActionResult<string> ConvertArrayByteToHex(string strArrayByte)
        {
            return googleConvert.ConvertArrayByteToHex(strArrayByte);
        }
        [HttpPost("ArrayByteToString")]
        public ActionResult<string> ConvertArrayByteToString(string strArrayByte)
        {
            return googleConvert.ConvertArrayByteToString(strArrayByte);
        }
        [HttpPost("Base64ToArrayByte")]
        public ActionResult<string> ConvertBase64ToArrayByte(string strBase64)
        {
            return googleConvert.ConvertBase64ToArrayByte(strBase64);
        }
        [HttpPost("Base64ToHex")]
        public ActionResult<string> ConvertBase64ToHex(string strBase64)
        {
            return googleConvert.ConvertBase64ToHex(strBase64);
        }
        [HttpPost("Base64ToString")]
        public ActionResult<string> ConvertBase64ToString(string strBase64)
        {
            return googleConvert.ConvertBase64ToString(strBase64);
        }
        [HttpPost("HexToArrayByte")]
        public ActionResult<string> ConvertHexToArrayByte(string strHex)
        {
            return googleConvert.ConvertHexToArrayByte(strHex);
        }
        [HttpPost("HexToBase64")]
        public ActionResult<string> ConvertHexToBase64(string strHex)
        {
            return googleConvert.ConvertHexToBase64(strHex);
        }
        [HttpPost("HexToString")]
        public ActionResult<string> ConvertHexToString(string strHex)
        {
            return googleConvert.ConvertHexToString(strHex);
        }
        [HttpPost("StringToArrayByte")]
        public ActionResult<string> ConvertStringToArrayByte(string str)
        {
            return googleConvert.ConvertStringToArrayByte(str);
        }
        [HttpPost("StringToHex")]
        public ActionResult<string> ConvertStringToHex(string str)
        {
            return googleConvert.ConvertStringToHex(str);
        }
    }
}
