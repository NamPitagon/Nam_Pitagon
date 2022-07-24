namespace GoogleConvert.Models
{
    public interface IGgConvert
    {
        #region Convert string -> base64,string -> hex, string -> arrayByte và ngược lại
        public string StringToBase64(string str);
        public string StringToHex(string str);
        public string StringToArrByte(string str);
        public string Base64ToString(string strBase64);
        public string HexToString(string strHex);
        public string ArrByteToString(string strArrayByte);
        #endregion

        #region Convert base64 -> hex, base64 -> arrayByte và ngược lại
        public string Base64ToHex(string strBase64);
        public string Base64ToArrByte(string strBase64);
        public string HexToBase64(string strHex);
        public string ArrByteToBase64(string strArrayByte);
        #endregion

        #region Convert hex -> arrayByte và ngược lại
        public string HexToArrByte(string strHex);
        public string ArrByteToHex(string strArrayByte);
        #endregion
    }
}
