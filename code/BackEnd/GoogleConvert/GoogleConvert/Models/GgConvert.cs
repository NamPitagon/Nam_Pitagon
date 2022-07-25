using GoogleConvert.Dto;
using System;
using System.Text;
namespace GoogleConvert.Models
{
    public class GgConvert : IGgConvert
    {
        public readonly ConvertShare _convertShare;
        public GgConvert(ConvertShare convertShare)
        {
            _convertShare = convertShare;
        }
        #region convert string -> ...
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
                            bytes = _convertShare.ConvertStringToArrByte(inputValue);
                            result = ArrByteToBase64(inputType, bytes);
                            break;
                        case ("Hex"):
                            bytes = _convertShare.ConvertStringToArrByte(inputValue);
                            result = ArrByteToHex(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            bytes = _convertShare.ConvertStringToArrByte(inputValue);
                            result = ArrByteToString(inputType, bytes);
                            break;
                        case ("String"):
                            result = InputToOutput(inputValue);
                            break;
                        default:
                            break;
                    }
                    break;
                case ("Base64"):
                    switch (outputType)
                    {
                        case ("String"):
                            bytes = _convertShare.ConvertBase64ToArrByte(inputValue);
                            result = ArrByteToString(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            bytes = _convertShare.ConvertBase64ToArrByte(inputValue);
                            result = ArrByteToBase64(inputType, bytes);
                            break;
                        case ("Hex"):
                            bytes = _convertShare.ConvertBase64ToArrByte(inputValue);
                            result = ArrByteToHex(inputType, bytes);
                            break;
                        case ("Base64"):
                            result = InputToOutput(inputValue);
                            break;
                        default:
                            break;
                    }
                    break;
                case ("Hex"):
                    switch (outputType)
                    {
                        case ("String"):
                            bytes = _convertShare.ConvertHexToArrByte(inputValue);
                            result = ArrByteToString(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            bytes = _convertShare.ConvertHexToArrByte(inputValue);
                            result = ArrByteToHex(inputType, bytes);
                            break;
                        case ("Base64"):
                            bytes = _convertShare.ConvertHexToArrByte(inputValue);
                            result = ArrByteToBase64(inputType, bytes);
                            break;
                        case ("Hex"):
                            result = InputToOutput(inputValue);
                            break;
                        default:
                            break;
                    }
                    break;
                case ("ArrayByte"):
                    switch (outputType)
                    {
                        case ("String"):
                            bytes = _convertShare.ConvertStringToArrByte(inputValue);
                            result = ArrByteToString(inputType, bytes);
                            break;
                        case ("Hex"):
                            bytes = _convertShare.ConvertStringToArrByte(inputValue);
                            result = ArrByteToHex(inputType, bytes);
                            break;
                        case ("Base64"):
                            bytes = _convertShare.ConvertStringToArrByte(inputValue);
                            result = ArrByteToBase64(inputType, bytes);
                            break;
                        case ("ArrayByte"):
                            result = InputToOutput(inputValue);
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
        #endregion
        public ResponseData ArrByteToString(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (inType == "String")
            {
                string rslt = _convertShare.ConvertArrByteToString(bytes);
                result.value = rslt;
                result.success = true;
                result.message = "OK";
            }
            else
            {
                result.value = Encoding.UTF8.GetString(bytes);
                result.success = true;
                result.message = "OK";

            }
            return result;
        }
        public ResponseData ArrByteToBase64(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (inType == "Base64")
            {
                string resultArrByte = _convertShare.ConvertArrByteToString(bytes);
                result.value = resultArrByte;
                result.success = true;
                result.message = "OK";
            }
            else
            {
                result.value = Convert.ToBase64String(bytes, 0, bytes.Length);
                result.success = true;
                result.message = "OK";

            }
            return result;
        }
        public ResponseData ArrByteToHex(string inType, byte[] bytes)
        {
            ResponseData result = new ResponseData();
            if (inType == "String")
            {
                StringBuilder strBuilder = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes)
                    strBuilder.AppendFormat("{0:X2}", b);
                result.value = strBuilder.ToString();
                result.success = true;
                result.message = "OK";
            }
            else if (inType == "Hex")
            {
                string rslt = _convertShare.ConvertArrByteToString(bytes);
                result.value = rslt;
                result.success = true;
                result.message = "OK";
            }
            else
            {
                result.value = BitConverter.ToString(bytes);
                result.success = true;
                result.message = "OK";

            }
            return result;
        }
        public ResponseData InputToOutput(string inputValue)
        {
            return new ResponseData { value = inputValue, success = true, message = "OK" };
        }
    }
}