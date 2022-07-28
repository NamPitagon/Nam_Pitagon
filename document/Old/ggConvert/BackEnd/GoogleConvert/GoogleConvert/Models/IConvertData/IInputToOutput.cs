using GoogleConvert.Dto;

namespace GoogleConvert.Models.IConvertData
{
    public interface IInputToOutput
    {
        public ResponseData InputToOutput(string inputValue);
    }
}
