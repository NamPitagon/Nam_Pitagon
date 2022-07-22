using System;
using System.IO;
using System.Text;
using System.Drawing;

namespace TestConvertData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reusltStringToBase64 = ConvertStringToBase64("Ha Noi");
            Console.WriteLine(reusltStringToBase64); // SGEgTm9p

            string resultBase64ToString = ConvertBase64toString("SGEgTm9p");
            Console.WriteLine(resultBase64ToString); // Ha Noi

            string resultStringToHex = ConvertStringToHex("abc");
            Console.WriteLine(resultStringToHex); // 616263

            string resultHexToString = ConvertHexToString("6100620063");
            Console.WriteLine(resultHexToString); // abc

            byte[] b = { (byte)'57', (byte)'55', (byte)'57', (byte)'56' };
            string resultByteArrayToString = ConvertByteArrayToString(b);
            Console.WriteLine(resultByteArrayToString); // ab$

            byte[] resultStringToArrayByte = ConvertStringToByteArray("ab$");
            Console.WriteLine(resultStringToArrayByte); // 97 98 36

            string resultBase64ToHex = ConvertBase64ToHex("V2hpdGU=");
            Console.WriteLine(resultBase64ToHex); // 57-68-69-74-65

            string resultHexToBase = ConvertHexToBase64("57-68-69-74-65");
            Console.WriteLine(resultHexToBase); // V2hpdGU=

            byte[] b1 = { (byte)'a', (byte)'b', (byte)'$' };
            string resultByteArrayToBase64 = ConvertArrayByteToBase64(b1);
            Console.WriteLine(resultByteArrayToBase64); // YWIk

            byte[] resultBase64ToArrayByte = ConvertStringToByteArray("9798");
            Console.WriteLine(resultBase64ToArrayByte); // 89 87 73 107

            byte[] resultHexToArrayByte = ConvertHexToArraybyte("61-62-24");
            Console.WriteLine(resultHexToArrayByte); // 97 98 36

            byte[] b2 = { (byte)'a', (byte)'b', (byte)'$' };
            string resultByteArrayToHex = ConvertArrayByteToHex(b2);
            Console.WriteLine(resultByteArrayToHex); // 61-62-24
        }

        #region Chuyển đổi từ string -> base64, sring -> hex, string -> byte[] và ngược lại
        public static string ConvertStringToBase64(string strOriginal)
        {
            // trả về 1 mảng byte 
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(strOriginal);

            string result = Convert.ToBase64String(bytes);

            return result;
        }
        public static string ConvertBase64toString(string strBase54)
        {
            // cũng cần phải chuyển đổi sang mảng byte
            byte[] bytes = Convert.FromBase64String(strBase54);
            string result = System.Text.Encoding.UTF8.GetString(bytes);
            return result;
        }

        public static string ConvertStringToHex(string strString)
        {
            // cũng cần phải chuyển đổi sang mảng byte
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(strString);
            StringBuilder strBuilder = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                strBuilder.AppendFormat("{0:X2}", b);
            }
            return strBuilder.ToString();
        }

        public static string ConvertHexToString(string strHex)
        {
            // vẫn cần phải chuyển đổi sang mảng byte
            var bytes = new byte[strHex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(strHex.Substring(i * 2, 2), 16);
            }
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        public static byte[] ConvertStringToByteArray(string str)
        {
            // sử dụng một mảng byte
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            return bytes;
        }

        public static string ConvertByteArrayToString(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }
        #endregion

        #region Chuyển đổi từ base64 -> hex, base64 -> byte[] và ngược lại
        public static string ConvertBase64ToHex(string strBase64)
        {
            byte[] bytes = Convert.FromBase64String(strBase64);
            string strHex = BitConverter.ToString(bytes);
            return strHex;
        }

        public static string ConvertHexToBase64(string strToHex)
        {
            strToHex = strToHex.Replace("-", "");
            int numberChar = strToHex.Length;
            // vẫn cần phải chuyển đổi sang mảng byte
            byte[] bytes = new byte[numberChar / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(strToHex.Substring(i * 2, 2), 16);
            }
            return Convert.ToBase64String(bytes);
        }

        public static byte[] ConvertBase64ToArraybyte(string strBase64)
        {
            return System.Convert.FromBase64String(strBase64);
        }

        public static string ConvertArrayByteToBase64(byte[] bytes)
        {
            return Convert.ToBase64String(bytes, 0, bytes.Length);
        }
        #endregion

        #region Chuyển đổi từ hex sang byte[] và ngược lại
        public static byte[] ConvertHexToArraybyte(string strHex)
        {
            strHex = strHex.Replace("-", "");
            int numberChar = strHex.Length;
            // vẫn cần phải chuyển đổi sang mảng byte
            byte[] bytes = new byte[numberChar / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(strHex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        public static string ConvertArrayByteToHex(byte[] bytes)
        {
            return BitConverter.ToString(bytes, 0, bytes.Length);
        }
        #endregion

    }
}
