using GoogleConvert.Dto;
using GoogleConvert.Models.ConvertArrByteToData;
using GoogleConvert.Models.ConvertToArrByte;

namespace GoogleConvert.Models.IConvertData
{
    public class ggConvert : IggConvert
    {
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
                            StringToArrByte strArr = new StringToArrByte();
                            bytes = strArr.DataToArrByte(inputValue);
                            ArrByteToBase64 arrBase64 = new ArrByteToBase64();
                            result = arrBase64.ArrByteToData(inputType, bytes);
                            break;
                            //case ("Hex"):
                            //    bytes = ConvertShare.ConvertStringToArrByte(inputValue);
                            //    result = ArrByteToHex(inputType, bytes);
                            //    break;
                            //case ("ArrayByte"):
                            //    bytes = ConvertShare.ConvertStringToArrByte(inputValue);
                            //    result = ArrByteToString(inputType, bytes);
                            //    break;
                            //case ("String"):
                            //    result = InputToOutput(inputValue);
                            //    break;
                            //default:
                            //    break;
                    }
                    break;
                case ("Base64"):
                    switch (outputType)
                    {
                        //case ("String"):
                        //    bytes = ConvertShare.ConvertBase64ToArrByte(inputValue);
                        //    result = ArrByteToString(inputType, bytes);
                        //    break;
                        //case ("ArrayByte"):
                        //    bytes = ConvertShare.ConvertBase64ToArrByte(inputValue);
                        //    result = ArrByteToBase64(inputType, bytes);
                        //    break;
                        //case ("Hex"):
                        //    bytes = ConvertShare.ConvertBase64ToArrByte(inputValue);
                        //    result = ArrByteToHex(inputType, bytes);
                        //    break;
                        //case ("Base64"):
                        //    result = InputToOutput(inputValue);
                        //    break;
                        //default:
                        //    break;
                    }
                    break;
                case ("Hex"):
                    switch (outputType)
                    {
                        //case ("String"):
                        //    bytes = ConvertShare.ConvertHexToArrByte(inputValue);
                        //    result = ArrByteToString(inputType, bytes);
                        //    break;
                        //case ("ArrayByte"):
                        //    bytes = ConvertShare.ConvertHexToArrByte(inputValue);
                        //    result = ArrByteToHex(inputType, bytes);
                        //    break;
                        //case ("Base64"):
                        //    bytes = ConvertShare.ConvertHexToArrByte(inputValue);
                        //    result = ArrByteToBase64(inputType, bytes);
                        //    break;
                        //case ("Hex"):
                        //    result = InputToOutput(inputValue);
                        //    break;
                        //default:
                        //    break;
                    }
                    break;
                case ("ArrayByte"):
                    switch (outputType)
                    {
                        //case ("String"):
                        //    bytes = ConvertShare.ConvertStringToArrByte(inputValue);
                        //    result = ArrByteToString(inputType, bytes);
                        //    break;
                        //case ("Hex"):
                        //    bytes = ConvertShare.ConvertStringToArrByte(inputValue);
                        //    result = ArrByteToHex(inputType, bytes);
                        //    break;
                        //case ("Base64"):
                        //    bytes = ConvertShare.ConvertStringToArrByte(inputValue);
                        //    result = ArrByteToBase64(inputType, bytes);
                        //    break;
                        //case ("ArrayByte"):
                        //    result = InputToOutput(inputValue);
                        //    break;
                        //default:
                        //    break;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
