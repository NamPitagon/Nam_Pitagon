using GoogleConvert.Dto;
using System;
using System.Text;
using System.Text.RegularExpressions;
namespace GoogleConvert.Models
{
    public class GgConvert : IGgConvert
    {
        public readonly ConvertShare _convertShare;

        public GgConvert(ConvertShare convertShare)
        {
            _convertShare = convertShare;
        }

        #region Convert string -> base64, string -> hex, string -> byte[] và ngược lại
        public ResponseData StringToBase64(string inputValue)
        {
            if (inputValue == null)
            {
                return new ResponseData { value = null, success = false, message = "Error" };
            }
            else
            {
                byte[] bytes = _convertShare.ConvertStringToArrByte(inputValue);
                return new ResponseData { value = Convert.ToBase64String(bytes), success = true, message = "OK" };
            }
        }

        public ResponseData StringToHex(string inputValue)
        {
            byte[] bytes = _convertShare.ConvertStringToArrByte(inputValue);
            StringBuilder strBuilder = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
                strBuilder.AppendFormat("{0:X2}", b);
            return new ResponseData { value = strBuilder.ToString(), success = true, message = "OK" };
        }

        public ResponseData StringToArrByte(string inputValue)
        {
            byte[] bytes = _convertShare.ConvertStringToArrByte(inputValue);
            string resultArrbyte = _convertShare.ConvertArrByteToString(bytes);
            return new ResponseData { value = resultArrbyte, success = true, message = "OK" };
        }

        public ResponseData ArrByteToString(string inputValue)
        {
            inputValue = Regex.Replace(inputValue, @"\s+", " ");
            string[] arr = inputValue.Split(new Char[] { ' ', '-' });
            byte[] bytes = new byte[arr.Length];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                    bytes[i] = (byte)int.Parse(arr[i].ToString());
            }
            catch (Exception e)
            {
                return new ResponseData { value = e.ToString(), success = false, message = "Error" };
            }
            return new ResponseData { value = Encoding.UTF8.GetString(bytes, 0, bytes.Length), success = true, message = "OK" };
        }

        public ResponseData Base64ToString(string inputValue)
        {
            byte[] bytes = _convertShare.ConvertBase64ToArrByte(inputValue);
            return new ResponseData { value = Encoding.UTF8.GetString(bytes), success = true, message = "OK" };
        }

        public ResponseData HexToString(string inputValue)
        {
            byte[] bytes = _convertShare.ConvertHexToArrByte(inputValue);
            return new ResponseData { value = Encoding.UTF8.GetString(bytes), success = true, message = "OK" };
        }
        #endregion

        #region Convert base64 -> hex, base -> byte[] và ngược lại
        public ResponseData Base64ToArrByte(string inputValue)
        {
            byte[] bytes = _convertShare.ConvertBase64ToArrByte(inputValue);
            string resultArrByte = _convertShare.ConvertArrByteToString(bytes);
            return new ResponseData { value = resultArrByte, success = true, message = "OK" };
        }

        public ResponseData Base64ToHex(string inputValue)
        {
            byte[] bytes = _convertShare.ConvertBase64ToArrByte(inputValue);
            return new ResponseData { value = BitConverter.ToString(bytes), success = true, message = "OK" };
        }

        public ResponseData ArrByteToBase64(string inputValue)
        {
            byte[] bytes = _convertShare.ConvertStringToArrByte(inputValue);
            return new ResponseData { value = Convert.ToBase64String(bytes, 0, bytes.Length), success = true, message = "OK" };
        }

        public ResponseData HexToBase64(string inputValue)
        {
            byte[] bytes = _convertShare.ConvertHexToArrByte(inputValue);
            return new ResponseData { value = Convert.ToBase64String(bytes), success = true, message = "OK" };
        }
        #endregion

        #region Convert Hex -> byte [] và ngược lại
        public ResponseData HexToArrByte(string inputValue)
        {
            byte[] bytes = _convertShare.ConvertHexToArrByte(inputValue);
            string resultArrbyte = _convertShare.ConvertArrByteToString(bytes);
            return new ResponseData { value = resultArrbyte, success = true, message = "OK" };
        }

        public ResponseData ArrByteToHex(string inputValue)
        {
            inputValue = Regex.Replace(inputValue, @"\s+", " ");
            string[] arr = inputValue.Split(new Char[] { ' ', '-' });
            byte[] bytes = new byte[arr.Length];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                    bytes[i] = (byte)int.Parse(arr[i].ToString());
            }
            catch (Exception e)
            {
                return new ResponseData { value = e.ToString(), success = false, message = "Error" };
            }
            return new ResponseData { value = BitConverter.ToString(bytes), success = true, message = "OK" };
        }
        #endregion
    }
}
