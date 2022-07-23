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
        public string ConvertStringToBase64(string str)
        {
            byte[] bytes = _convertShare.ConvertStringToArrayByte(str);
            return Convert.ToBase64String(bytes);
        }

        public string ConvertStringToHex(string str)
        {
            byte[] bytes = _convertShare.ConvertStringToArrayByte(str);
            StringBuilder strBuilder = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
                strBuilder.AppendFormat("{0:X2}", b);
            return strBuilder.ToString();
        }
        public string ConvertStringToArrayByte(string str)
        {
            byte[] bytes = _convertShare.ConvertStringToArrayByte(str);
            StringBuilder strBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                strBuilder.Append(b.ToString() + " ");
            }
            return strBuilder.ToString().Trim();
        }
        public string ConvertArrayByteToString(string strArrayByte)
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
                return e.ToString();
            }
            return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }
        public string ConvertBase64ToString(string strBase64)
        {
            byte[] bytes = _convertShare.ConvertBase64ToArrayBye(strBase64);
            return Encoding.UTF8.GetString(bytes);
        }
        public string ConvertHexToString(string strHex)
        {
            byte[] bytes = _convertShare.ConvertHexToArrayByte(strHex);
            return Encoding.UTF8.GetString(bytes);
        }
        #endregion

        #region Convert base64 -> hex, base -> byte[] và ngược lại
        public string ConvertBase64ToArrayByte(string strBase64)
        {
            byte[] bytes = _convertShare.ConvertBase64ToArrayBye(strBase64);
            StringBuilder strBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                strBuilder.Append(b.ToString() + " ");
            }
            return strBuilder.ToString().Trim();
        }

        public string ConvertBase64ToHex(string strBase64)
        {
            byte[] bytes = _convertShare.ConvertBase64ToArrayBye(strBase64);
            return BitConverter.ToString(bytes);
        }
        public string ConvertArrayByteToBase64(string strArrayByte)
        {
            byte[] bytes = _convertShare.ConvertStringToArrayByte(strArrayByte);
            return Convert.ToBase64String(bytes, 0, bytes.Length);
        }
        public string ConvertHexToBase64(string strHex)
        {
            byte[] bytes = _convertShare.ConvertHexToArrayByte(strHex);
            return Convert.ToBase64String(bytes);
        }
        #endregion

        #region Convert Hex -> byte [] và ngược lại
        public string ConvertHexToArrayByte(string strHex)
        {
            byte[] bytes = _convertShare.ConvertHexToArrayByte(strHex);
            StringBuilder strBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                strBuilder.Append(b.ToString() + " ");
            }
            return strBuilder.ToString().Trim();
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
                return e.ToString();
            }
            return BitConverter.ToString(bytes);
        }
        #endregion
    }
}