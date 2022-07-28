using GoogleConvert.Dto;
using GoogleConvert.Share;
using System;

namespace GoogleConvert.Models.ConvertArrByteToData
{
    public class ArrByteToBase64 : ConvertArrByteToData
    {
        ResponseData ArrByteToData(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (inType == "Base64")
            {
                string resultArrByte = ShareFunction.ConvertArrByteToString(bytes);
                result.value = resultArrByte;
                result.success = true;
            }
            else
            {
                result.value = Convert.ToBase64String(bytes, 0, bytes.Length);
                result.success = true;
            }
            return result;
        }
    }
}
