using GoogleConvert.Dto;

namespace GoogleConvert.Models.ConvertArrByteToData
{
    public class ConvertArrByteToData
    {
        public ResponseData ArrByteToData(string inType, byte[] bytes)
        {
            return new ResponseData { value = "", success = false };
        }
    }
}
