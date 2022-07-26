using GoogleConvert.Dto;
using GoogleConvert.Models.ConvertDataToArrByte;
using System;

namespace GoogleConvert.Models.ConvertArrbyteToData
{
    public class ArrByteToBase64 : ArrByteToData
    {
        public override ResponseData ArrayByteToData(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (bytes == null)
            {
                result.value = "";
                result.success = false;
                result.message = "Error";
            }
            else
            {
                if (inType == "Base64")
                {
                    string resultArrByte = DataToArrByte.FormatArrByteToString(bytes);
                    result.value = resultArrByte;
                }
                else result.value = Convert.ToBase64String(bytes, 0, bytes.Length);
                result.success = true;
                result.message = "OK";
            }
            return result;
        }
    }
}
