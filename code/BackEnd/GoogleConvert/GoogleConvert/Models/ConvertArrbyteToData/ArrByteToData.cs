using GoogleConvert.Dto;

namespace GoogleConvert.Models.ConvertArrbyteToData
{
    public class ArrByteToData
    {
        public virtual ResponseData ArrayByteToData(string inType, byte[] bytes)
        {
            return new ResponseData { value = "", message = "", success = true };
        }
    }
}
