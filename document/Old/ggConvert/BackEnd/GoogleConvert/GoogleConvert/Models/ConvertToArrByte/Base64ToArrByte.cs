using System;

namespace GoogleConvert.Models.ConvertToArrByte
{
    public class Base64ToArrByte : ConvertDataToArrByte
    {
        byte[] DataToArrByte(string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue))
                return null;
            else
                return Convert.FromBase64String(inputValue);
        }
    }
}
