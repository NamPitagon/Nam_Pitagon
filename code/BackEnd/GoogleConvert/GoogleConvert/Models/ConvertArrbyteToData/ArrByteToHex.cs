using GoogleConvert.Dto;
using GoogleConvert.Models.ConvertDataToArrByte;
using System;
using System.Text;

namespace GoogleConvert.Models.ConvertArrbyteToData
{
    public class ArrByteToHex : ArrByteToData
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
                if (inType == "String")
                {
                    StringBuilder strBuilder = new StringBuilder(bytes.Length * 2);
                    foreach (byte b in bytes)
                        strBuilder.AppendFormat("{0:X2}", b);
                    result.value = strBuilder.ToString();
                }
                else if (inType == "Hex")
                {
                    string rslt = DataToArrByte.FormatArrByteToString(bytes);
                    result.value = rslt;
                }
                else result.value = BitConverter.ToString(bytes);
                result.success = true;
                result.message = "OK";
            }
            return result;
        }
    }
}
