using System;
using System.Text.RegularExpressions;

namespace GoogleConvert.Models.ConvertToArrByte
{
    public class HexToArrByte : ConvertDataToArrByte
    {
        byte[] DataToArrByte(string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue))
                return null;
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
    }
}
