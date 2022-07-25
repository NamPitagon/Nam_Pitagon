using GoogleConvert.Dto;

namespace GoogleConvert.Models
{
    public interface IArrByteToOutType
    {
        public ResponseData ArrByteToString(string inType, byte[] bytes);
        public ResponseData ArrByteToHex(string inType, byte[] bytes);
        public ResponseData ArrByteToBase64(string inType, byte[] bytes);
    }
}
