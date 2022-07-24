using GoogleConvert.Dto;

namespace GoogleConvert.Models
{
    public interface IGgConvert
    {
        #region Convert string -> base64,string -> hex, string -> arrayByte và ngược lại
        public ResponseData StringToBase64(string inputValue);
        public ResponseData StringToHex(string inputValue);
        public ResponseData StringToArrByte(string inputValue);
        public ResponseData Base64ToString(string inputValue);
        public ResponseData HexToString(string inputValue);
        public ResponseData ArrByteToString(string inputValue);
        #endregion

        #region Convert base64 -> hex, base64 -> arrayByte và ngược lại
        public ResponseData Base64ToHex(string inputValue);
        public ResponseData Base64ToArrByte(string inputValue);
        public ResponseData HexToBase64(string inputValue);
        public ResponseData ArrByteToBase64(string inputValue);
        #endregion

        #region Convert hex -> arrayByte và ngược lại
        public ResponseData HexToArrByte(string inputValue);
        public ResponseData ArrByteToHex(string inputValue);
        #endregion
    }
}
