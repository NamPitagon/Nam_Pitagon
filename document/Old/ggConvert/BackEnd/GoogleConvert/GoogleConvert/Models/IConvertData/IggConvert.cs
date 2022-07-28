using GoogleConvert.Dto;

namespace GoogleConvert.Models.IConvertData
{
    public interface IggConvert
    {
        public ResponseData ggConvertData(string inputType, string outputType, string inputValue);
    }
}
