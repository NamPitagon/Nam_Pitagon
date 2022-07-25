using GoogleConvert.Dto;

namespace GoogleConvert.Models
{
    public interface IGgConvert
    {
        public ResponseData ggConvertData(string inputType, string outputType, string inputValue);
        public ResponseData ArrByteToString(string inType, byte[] bytes);
        public ResponseData ArrByteToBase64(string inType, byte[] bytes);
        public ResponseData ArrByteToHex(string inType, byte[] bytes);
        public ResponseData InputToOutput(string inType);
    }
}
