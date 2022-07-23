using System.Text;
using System.Text.RegularExpressions;

namespace GoogleConvert.Models
{
    public class ConvertShare
    {
        public byte[] StringToArrByte(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public byte[] Base64ToArrByte(string strBase64)
        {
            return Convert.FromBase64String(strBase64);
        }

        public byte[] HexToArrByte(string strHex)
        {
            strHex = Regex.Replace(strHex, @"\s+|-", "");
            byte[] bytes = new byte[strHex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(strHex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        public string ArrByteToString(byte[] bytes)
        {
            StringBuilder strBuilder = new StringBuilder();
            foreach (byte b in bytes)
                strBuilder.Append(b.ToString() + " ");
            return strBuilder.ToString().Trim();
        }
    }
}
