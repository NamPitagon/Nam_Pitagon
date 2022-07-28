using GoogleConvert.Dto;
using GoogleConvert.Share;
using System.Text;

namespace GoogleConvert.Models.ConvertArrByteToData
{
    public class ArrByteToString : ConvertArrByteToData
    {
        ResponseData ArrByteToData(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (inType == "String")
            {
                string rslt = ShareFunction.ConvertArrByteToString(bytes);
                result.value = rslt;
                result.success = true;
            }
            else
            {
                result.value = Encoding.UTF8.GetString(bytes);
                result.success = true;
            }
            return result;
        }
    }
}
