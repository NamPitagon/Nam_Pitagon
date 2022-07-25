using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace GoogleConvert.Models
{
    public class ConvertShare
    {
        public byte[] ConvertStringToArrByte(string inputValue)
        {
            byte[] bytes = new byte[] { };
            if (string.IsNullOrEmpty(inputValue)) return null;
            else
            {
                string removeChar = inputValue;
                removeChar = Regex.Replace(removeChar, @"[^0-9]", "");
                if (IsNumeric(removeChar) && removeChar != "")
                {
                    inputValue = Regex.Replace(inputValue, @"\s+", " ");
                    string[] arr = inputValue.Split(new Char[] { ' ', '-' });
                    bytes = new byte[arr.Length];
                    for (int i = 0; i < arr.Length; i++)
                        bytes[i] = (byte)int.Parse(arr[i].ToString());
                }
                else
                {
                    bytes = Encoding.UTF8.GetBytes(inputValue);
                }
            }
            return bytes;
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

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
