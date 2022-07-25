using GoogleConvert.Dto;
namespace GoogleConvert.Models
{
    public class GgConvert : IGgConvert
    {
        ArrByteToOutType valOut = new ArrByteToOutType();
        InputSameOutputType outValueSame = new InputSameOutputType();
        public ResponseData ggConvertData(string inputType, string outputType, string inputValue)
        {
            ResponseData result = new ResponseData();
            byte[] bytes = new byte[] { };
            switch (inputType)
            {
                case ("String"):
                    switch (outputType)
                    {
                        case ("Base64"):
                            bytes = ConvertToArrByte.ConvertStringToArrByte(inputValue);
                            result = valOut.ArrByteToBase64(inputType, bytes);
                            break;
                        case ("Hex"):
                            bytes = ConvertToArrByte.ConvertStringToArrByte(inputValue);
                            result = valOut.ArrByteToHex(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            bytes = ConvertToArrByte.ConvertStringToArrByte(inputValue);
                            result = valOut.ArrByteToString(inputType, bytes);
                            break;
                        case ("String"):
                            result = outValueSame.InputSameOutput(inputValue);
                            break;
                        default:
                            break;
                    }
                    break;
                case ("Base64"):
                    switch (outputType)
                    {
                        case ("String"):
                            bytes = ConvertToArrByte.ConvertBase64ToArrByte(inputValue);
                            result = valOut.ArrByteToString(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            bytes = ConvertToArrByte.ConvertBase64ToArrByte(inputValue);
                            result = valOut.ArrByteToBase64(inputType, bytes);
                            break;
                        case ("Hex"):
                            bytes = ConvertToArrByte.ConvertBase64ToArrByte(inputValue);
                            result = valOut.ArrByteToHex(inputType, bytes);
                            break;
                        case ("Base64"):
                            result = outValueSame.InputSameOutput(inputValue);
                            break;
                        default:
                            break;
                    }
                    break;
                case ("Hex"):
                    switch (outputType)
                    {
                        case ("String"):
                            bytes = ConvertToArrByte.ConvertHexToArrByte(inputValue);
                            result = valOut.ArrByteToString(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            bytes = ConvertToArrByte.ConvertHexToArrByte(inputValue);
                            result = valOut.ArrByteToHex(inputType, bytes);
                            break;
                        case ("Base64"):
                            bytes = ConvertToArrByte.ConvertHexToArrByte(inputValue);
                            result = valOut.ArrByteToBase64(inputType, bytes);
                            break;
                        case ("Hex"):
                            result = outValueSame.InputSameOutput(inputValue);
                            break;
                        default:
                            break;
                    }
                    break;
                case ("ArrayByte"):
                    switch (outputType)
                    {
                        case ("String"):
                            bytes = ConvertToArrByte.ConvertStringToArrByte(inputValue);
                            result = valOut.ArrByteToString(inputType, bytes);
                            break;
                        case ("Hex"):
                            bytes = ConvertToArrByte.ConvertStringToArrByte(inputValue);
                            result = valOut.ArrByteToHex(inputType, bytes);
                            break;
                        case ("Base64"):
                            bytes = ConvertToArrByte.ConvertStringToArrByte(inputValue);
                            result = valOut.ArrByteToBase64(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            result = outValueSame.InputSameOutput(inputValue);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}