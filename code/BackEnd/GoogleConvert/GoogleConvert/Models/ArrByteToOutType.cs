using GoogleConvert.Dto;
using System;
using System.Text;

namespace GoogleConvert.Models
{
    public class ArrByteToOutType : IArrByteToOutType
    {
        public ResponseData ArrByteToBase64(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (inType == "Base64")
            {
                string resultArrByte = ConvertToArrByte.ConvertArrByteToString(bytes);
                result.value = resultArrByte;
                result.success = true;
                result.message = "OK";
            }
            else
            {
                result.value = Convert.ToBase64String(bytes, 0, bytes.Length);
                result.success = true;
                result.message = "OK";

            }
            return result;
        }

        public ResponseData ArrByteToHex(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (inType == "String")
            {
                StringBuilder strBuilder = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes)
                    strBuilder.AppendFormat("{0:X2}", b);
                result.value = strBuilder.ToString();
                result.success = true;
                result.message = "OK";
            }
            else if (inType == "Hex")
            {
                string rslt = ConvertToArrByte.ConvertArrByteToString(bytes);
                result.value = rslt;
                result.success = true;
                result.message = "OK";
            }
            else
            {
                result.value = BitConverter.ToString(bytes);
                result.success = true;
                result.message = "OK";

            }
            return result;
        }

        public ResponseData ArrByteToString(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (inType == "String")
            {
                string rslt = ConvertToArrByte.ConvertArrByteToString(bytes);
                result.value = rslt;
                result.success = true;
                result.message = "OK";
            }
            else
            {
                result.value = Encoding.UTF8.GetString(bytes);
                result.success = true;
                result.message = "OK";

            }
            return result;
        }
    }
}
