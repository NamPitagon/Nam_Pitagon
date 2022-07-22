using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Translate.Models
{
    public interface IInputData
    {
        
        public string SendRequestStringToByte(string request);
        public string SendRequestStringToBase64(string request);
        public string SendRequestStringToHex(string request);
        public string SendRequestByteToString(string request);

        public string SendRequestHexToString(string request);
        public string SendRequestBase64ToString(string request);
        public string SendRequestHexToByte(string request);
        public string SendRequestByteToHex(string request);
        public string SendRequestBase64ToByte(string request);
        public string SendRequestByteToBase64(string request);

        public string SendRequestBase64ToHex(string request);
        public string SendRequestHexToBase64(string request);
    }
}
