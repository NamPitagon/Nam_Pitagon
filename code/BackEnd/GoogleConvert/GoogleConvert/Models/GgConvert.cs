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
        public string StringToBase64(string str)
        {
            byte[] bytes = _convertShare.StringToArrByte(str);
            return Convert.ToBase64String(bytes);
        }

        public string StringToHex(string str)
        {
            byte[] bytes = _convertShare.StringToArrByte(str);
            StringBuilder strBuilder = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
                strBuilder.AppendFormat("{0:X2}", b);
            return strBuilder.ToString();
        }

        public string StringToArrByte(string str)
        {
            byte[] bytes = _convertShare.StringToArrByte(str);
            string resultArrbyte = _convertShare.ArrByteToString(bytes);
            return resultArrbyte;
        }

        public string ArrByteToString(string strArrayByte)
        {
            strArrayByte = Regex.Replace(strArrayByte, @"\s+", " ");
            string[] arr = strArrayByte.Split(new Char[] { ' ', '-' });
            byte[] bytes = new byte[arr.Length];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                    bytes[i] = (byte)int.Parse(arr[i].ToString());
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }

        public string Base64ToString(string strBase64)
        {
            byte[] bytes = _convertShare.Base64ToArrByte(strBase64);
            return Encoding.UTF8.GetString(bytes);
        }

        public string HexToString(string strHex)
        {
            byte[] bytes = _convertShare.HexToArrByte(strHex);
            return Encoding.UTF8.GetString(bytes);
        }
        #endregion

        #region Convert base64 -> hex, base -> byte[] và ngược lại
        public string Base64ToArrByte(string strBase64)
        {
            byte[] bytes = _convertShare.Base64ToArrByte(strBase64);
            string resultArrByte = _convertShare.ArrByteToString(bytes);
            return resultArrByte;
        }

        public string Base64ToHex(string strBase64)
        {
            byte[] bytes = _convertShare.Base64ToArrByte(strBase64);
            return BitConverter.ToString(bytes);
        }

        public string ArrByteToBase64(string strArrayByte)
        {
            byte[] bytes = _convertShare.StringToArrByte(strArrayByte);
            return Convert.ToBase64String(bytes, 0, bytes.Length);
        }

        public string HexToBase64(string strHex)
        {
            byte[] bytes = _convertShare.HexToArrByte(strHex);
            return Convert.ToBase64String(bytes);
        }
        #endregion

        #region Convert Hex -> byte [] và ngược lại
        public string HexToArrByte(string strHex)
        {
            byte[] bytes = _convertShare.HexToArrByte(strHex);
            string resultArrbyte = _convertShare.ArrByteToString(bytes);
            return resultArrbyte;
        }

        public string ArrByteToHex(string strArrayByte)
        {
            strArrayByte = Regex.Replace(strArrayByte, @"\s+", " ");
            string[] arr = strArrayByte.Split(new Char[] { ' ', '-' });
            byte[] bytes = new byte[arr.Length];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                    bytes[i] = (byte)int.Parse(arr[i].ToString());
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return BitConverter.ToString(bytes);
        }
        #endregion
    }
}
