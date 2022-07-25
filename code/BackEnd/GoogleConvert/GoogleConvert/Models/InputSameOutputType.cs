using GoogleConvert.Dto;

namespace GoogleConvert.Models
{
    public class InputSameOutputType : IInputSameOutput
    {
        public ResponseData InputSameOutput(string inputValue)
        {
            return new ResponseData { value = inputValue, success = true, message = "OK" };
        }
    }
}
