using GoogleConvert.Dto;
using GoogleConvert.Share;
using System;
using System.Text;

namespace GoogleConvert.Models.ConvertArrByteToData
{
    public class ArrByteToHex : ConvertArrByteToData
    {
        ResponseData ArrByteToData(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (inType == "String")
            {
                StringBuilder strBuilder = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes)
                    strBuilder.AppendFormat("{0:X2}", b);
                result.value = strBuilder.ToString();
                result.success = true;
            }
            else if (inType == "Hex")
            {
                string rslt = ShareFunction.ConvertArrByteToString(bytes);
                result.value = rslt;
                result.success = true;
            }
            else
            {
                result.value = BitConverter.ToString(bytes);
                result.success = true;
            }
            return result;
        }
    }
}
