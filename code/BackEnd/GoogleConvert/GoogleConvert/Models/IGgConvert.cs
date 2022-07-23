namespace GoogleConvert.Models
{
    public interface IGgConvert
    {
        #region Convert string -> base64,string -> hex, string -> arrayByte và ngược lại
        public string ConvertStringToBase64(string str);
        public string ConvertStringToHex(string str);
        public string ConvertStringToArrayByte(string str);
        public string ConvertBase64ToString(string strBase64);
        public string ConvertHexToString(string strHex);
        public string ConvertArrayByteToString(string strArrayByte);
        #endregion

        #region Convert base64 -> hex, base64 -> arrayByte và ngược lại
        public string ConvertBase64ToHex(string strBase64);
        public string ConvertBase64ToArrayByte(string strBase64);
        public string ConvertHexToBase64(string strHex);
        public string ConvertArrayByteToBase64(string strArrayByte);
        #endregion

        #region Convert hex -> arrayByte và ngược lại
        public string ConvertHexToArrayByte(string strHex);
        public string ConvertArrayByteToHex(string strArrayByte);
        #endregion
    }
}
