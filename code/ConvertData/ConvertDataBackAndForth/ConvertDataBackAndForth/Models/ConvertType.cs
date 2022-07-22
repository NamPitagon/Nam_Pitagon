using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConvertDataBackAndForth.Models
{
    public class ConvertType : IConvertType
    {
        public readonly ConvertDataToArrayByte _convertDataToArray;

        public ConvertType(ConvertDataToArrayByte convertDataToArray)
        {
            _convertDataToArray = convertDataToArray;
        }

        public string ConvertArrayByteToBase64(string strArrayByte)
        {
            byte[] bytes = _convertDataToArray.ConvertStringToArrayByte(strArrayByte);
            return Convert.ToBase64String(bytes, 0, bytes.Length);
        }

        public string ConvertArrayByteToHex(string strArrayByte)
        {
            strArrayByte = Regex.Replace(strArrayByte, @"\s+", " ");
            string[] arr = strArrayByte.Split(new Char[] { ' ', '-' });
            byte[] bytes = new byte[arr.Length];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    bytes[i] = (byte)int.Parse(arr[i].ToString());
                }
            }
            catch (Exception e)
            {
                return "Không có mảng byte";
            }
            return BitConverter.ToString(bytes);
        }

        public string ConvertArrayByteToString(string strArrayByte)
        {
            strArrayByte = Regex.Replace(strArrayByte, @"\s+", " ");
            string[] arr = strArrayByte.Split(new Char [] {' ', '-'});
            byte[] bytes = new byte[arr.Length];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    bytes[i] =(byte)int.Parse(arr[i].ToString());
                }
            }
            catch(Exception e)
            {
                return "Không có mảng byte";
            }
            return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }

        public string ConvertBase64ToArrayByte(string strBase64)
        {
            byte[] bytes = _convertDataToArray.ConvertBase64ToArrayBye(strBase64);
            StringBuilder strBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                strBuilder.Append(b.ToString() + " ");
            }
            return strBuilder.ToString().Trim();
        }

        public string ConvertBase64ToHex(string strBase64)
        {
            byte[] bytes = _convertDataToArray.ConvertBase64ToArrayBye(strBase64);
            return BitConverter.ToString(bytes);
        }

        public string ConvertBase64ToString(string strBase64)
        {
            byte[] bytes = _convertDataToArray.ConvertBase64ToArrayBye(strBase64);
            return Encoding.UTF8.GetString(bytes);
        }

        public string ConvertHexToArrayByte(string strHex)
        {
            byte[] bytes = _convertDataToArray.ConvertHexToArrayByte(strHex);
            StringBuilder strBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                strBuilder.Append(b.ToString() + " ");
            }
            return strBuilder.ToString().Trim();
        }

        public string ConvertHexToBase64(string strHex)
        {
            byte[] bytes = _convertDataToArray.ConvertHexToArrayByte(strHex);
            return Convert.ToBase64String(bytes);
        }

        public string ConvertHexToString(string strHex)
        {
            byte[] bytes = _convertDataToArray.ConvertHexToArrayByte(strHex);
            return Encoding.UTF8.GetString(bytes);
        }

        public string ConvertStringToArrayByte(string str)
        {
            byte[] bytes = _convertDataToArray.ConvertStringToArrayByte(str);
            StringBuilder strBuilder = new StringBuilder();
            foreach(byte b in bytes)
            {
                strBuilder.Append(b.ToString() + " ");
            }
            return strBuilder.ToString().Trim();
        }

        public string ConvertStringToBase64(string str)
        {
            byte[] bytes = _convertDataToArray.ConvertStringToArrayByte(str);
            return Convert.ToBase64String(bytes);
        }

        public string ConvertStringToHex(string str)
        {
            byte[] bytes = _convertDataToArray.ConvertStringToArrayByte(str);
            StringBuilder strBuilder = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
                strBuilder.AppendFormat("{0:X2}", b);
            return strBuilder.ToString();
        }
    }
}
