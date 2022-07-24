using System;
using System.Text;
using System.Text.RegularExpressions;
namespace GoogleConvert.Models
{
    public class ConvertShare
    {
        public byte[] ConvertStringToArrByte(string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue)) return null;
            else return Encoding.UTF8.GetBytes(inputValue);
        }

        public byte[] ConvertBase64ToArrByte(string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue)) return null;
            else return Convert.FromBase64String(inputValue);
        }

        public byte[] ConvertHexToArrByte(string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue)) return null;
            else
            {
                inputValue = Regex.Replace(inputValue, @"\s+|-", "");
                byte[] bytes = new byte[inputValue.Length / 2];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = Convert.ToByte(inputValue.Substring(i * 2, 2), 16);
                }
                return bytes;
            }
        }

        public string ConvertArrByteToString(byte[] bytes)
        {
            if (bytes.Length == 0) return null;
            else
            {
                StringBuilder strBuilder = new StringBuilder();
                foreach (byte b in bytes)
                    strBuilder.Append(b.ToString() + " ");
                return strBuilder.ToString().Trim();
            }
        }
    }
}
