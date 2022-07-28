using GoogleConvert.Dto;

namespace GoogleConvert.Models.IConvertData
{
    public class InToOut : IInputToOutput
    {
        public ResponseData InputToOutput(string inputValue)
        {
            return new ResponseData
            {
                value = inputValue,
                success = true
            };
        }
    }
}
