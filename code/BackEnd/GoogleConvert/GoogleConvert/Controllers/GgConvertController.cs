using GoogleConvert.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoogleConvert.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class GgConvertController : ControllerBase
    {
        public IGgConvert googleConvert = new GgConvert(new ConvertShare());

        [HttpPost("StringToBase64")]
        public ActionResult<string> StringToBase64(string str)
        {
            return googleConvert.StringToBase64(str);
        }

        [HttpPost("StringToArrByte")]
        public ActionResult<string> StringToArrByte(string str)
        {
            return googleConvert.StringToArrByte(str);
        }

        [HttpPost("StringToHex")]
        public ActionResult<string> StringToHex(string str)
        {
            return googleConvert.StringToHex(str);
        }

        [HttpPost("ArrByteToBase64")]
        public ActionResult<string> ArrByteToBase64(string strArrayByte)
        {
            return googleConvert.ArrByteToBase64(strArrayByte);
        }

        [HttpPost("ArrByteToHex")]
        public ActionResult<string> ArrByteToHex(string strArrayByte)
        {
            return googleConvert.ArrByteToHex(strArrayByte);
        }

        [HttpPost("ArrByteToString")]
        public ActionResult<string> ArrByteToString(string strArrayByte)
        {
            return googleConvert.ArrByteToString(strArrayByte);
        }

        [HttpPost("Base64ToArrByte")]
        public ActionResult<string> Base64ToArrByte(string strBase64)
        {
            return googleConvert.Base64ToArrByte(strBase64);
        }

        [HttpPost("Base64ToHex")]
        public ActionResult<string> Base64ToHex(string strBase64)
        {
            return googleConvert.Base64ToHex(strBase64);
        }

        [HttpPost("Base64ToString")]
        public ActionResult<string> Base64ToString(string strBase64)
        {
            return googleConvert.Base64ToString(strBase64);
        }

        [HttpPost("HexToArrByte")]
        public ActionResult<string> HexToArrByte(string strHex)
        {
            return googleConvert.HexToArrByte(strHex);
        }

        [HttpPost("HexToBase64")]
        public ActionResult<string> HexToBase64(string strHex)
        {
            return googleConvert.HexToBase64(strHex);
        }

        [HttpPost("HexToString")]
        public ActionResult<string> HexToString(string strHex)
        {
            return googleConvert.HexToString(strHex);
        }
    }
}
