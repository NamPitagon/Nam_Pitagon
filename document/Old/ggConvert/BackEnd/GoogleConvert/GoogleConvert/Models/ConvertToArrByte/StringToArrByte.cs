using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GoogleConvert.Models.ConvertToArrByte
{
    public class StringToArrByte : ConvertDataToArrByte
    {
        byte[] DataToArrByte(string inputValue)
        {
            byte[] bytes = new byte[] { };
            if (string.IsNullOrEmpty(inputValue))
                return null;
            else
            {
                string removeChar = inputValue;
                removeChar = Regex.Replace(removeChar, @"[^0-9]", "");
                if (removeChar.All(char.IsNumber) && removeChar != "")
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
    }
}
