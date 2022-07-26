using GoogleConvert.Dto;
using GoogleConvert.Models.ConvertDataToArrByte;
using System.Text;

namespace GoogleConvert.Models.ConvertArrbyteToData
{
    public class ArrByteToString : ArrByteToData
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
                    string rslt = DataToArrByte.FormatArrByteToString(bytes);
                    result.value = rslt;
                }
                else result.value = Encoding.UTF8.GetString(bytes);
                result.success = true;
                result.message = "OK";
            }
            return result;
        }
    }
}
