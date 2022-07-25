using GoogleConvert.Dto;

namespace GoogleConvert.Models
{
    public interface IGgConvert
    {
        public ResponseData ggConvertData(string inputType, string outputType, string inputValue);
    }
}
