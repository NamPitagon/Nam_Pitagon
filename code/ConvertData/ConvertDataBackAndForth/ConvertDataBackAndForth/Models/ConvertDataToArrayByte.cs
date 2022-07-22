using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConvertDataBackAndForth.Models
{
    public class ConvertDataToArrayByte
    {
        public byte[] ConvertStringToArrayByte(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public byte[] ConvertBase64ToArrayBye(string strBase64)
        {
            return Convert.FromBase64String(strBase64);
        }

        public byte[] ConvertHexToArrayByte(string strHex)
        {
            strHex = Regex.Replace(strHex, @"\s+|-", "");
            byte[] bytes = new byte[strHex.Length/2];
            for(int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(strHex.Substring(i*2, 2), 16);   
            }
            return bytes;
        }
    }
}
