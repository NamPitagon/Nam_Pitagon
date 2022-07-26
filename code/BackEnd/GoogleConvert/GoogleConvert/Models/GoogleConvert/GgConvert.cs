using GoogleConvert.Dto;
using GoogleConvert.Models.ConvertArrbyteToData;
using GoogleConvert.Models.ConvertDataToArrByte;

namespace GoogleConvert.Models.GoogleConvert
{
    public class GgConvert : IGgConvert
    {
        public ResponseData ggConvertData(string inputType, string outputType, string inputValue)
        {
            ResponseData result = new ResponseData();
            ArrByteToHex toArrHex = new ArrByteToHex();
            ArrByteToString toArrString = new ArrByteToString();
            ArrByteToBase64 toArrBase64 = new ArrByteToBase64();
            byte[] bytes = new byte[] { };
            switch (inputType)
            {
                case ("String"):
                    switch (outputType)
                    {
                        case ("Base64"):
                            bytes = DataToArrByte.StringToArrByte(inputValue);
                            result = toArrBase64.ArrayByteToData(inputType, bytes);
                            break;
                        case ("Hex"):
                            bytes = DataToArrByte.StringToArrByte(inputValue);
                            result = toArrHex.ArrayByteToData(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            bytes = DataToArrByte.StringToArrByte(inputValue);
                            result = toArrString.ArrayByteToData(inputType, bytes);
                            break;
                        default:
                            break;
                    }
                    break;
                case ("Base64"):
                    switch (outputType)
                    {
                        case ("String"):
                            bytes = DataToArrByte.Base64ToArrByte(inputValue);
                            result = toArrString.ArrayByteToData(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            bytes = DataToArrByte.Base64ToArrByte(inputValue);
                            result = toArrBase64.ArrayByteToData(inputType, bytes);
                            break;
                        case ("Hex"):
                            bytes = DataToArrByte.Base64ToArrByte(inputValue);
                            result = toArrHex.ArrayByteToData(inputType, bytes);
                            break;
                        default:
                            break;
                    }
                    break;
                case ("Hex"):
                    switch (outputType)
                    {
                        case ("String"):
                            bytes = DataToArrByte.HexToArrByte(inputValue);
                            result = toArrString.ArrayByteToData(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            bytes = DataToArrByte.HexToArrByte(inputValue);
                            result = toArrHex.ArrayByteToData(inputType, bytes);
                            break;
                        case ("Base64"):
                            bytes = DataToArrByte.HexToArrByte(inputValue);
                            result = toArrBase64.ArrayByteToData(inputType, bytes);
                            break;
                        default:
                            break;
                    }
                    break;
                case ("ArrayByte"):
                    switch (outputType)
                    {
                        case ("String"):
                            bytes = DataToArrByte.StringToArrByte(inputValue);
                            result = toArrString.ArrayByteToData(inputType, bytes);
                            break;
                        case ("Hex"):
                            bytes = DataToArrByte.StringToArrByte(inputValue);
                            result = toArrHex.ArrayByteToData(inputType, bytes);
                            break;
                        case ("Base64"):
                            bytes = DataToArrByte.StringToArrByte(inputValue);
                            result = toArrBase64.ArrayByteToData(inputType, bytes);
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
