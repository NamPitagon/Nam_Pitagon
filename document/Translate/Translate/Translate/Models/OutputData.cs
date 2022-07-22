using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Models
{
    public class OutputData
    {
        //public string Receive(string information)
        //{
        //    return information;
        //}
        public Byte[] ConvertStringToByte(string request)
        {
            return Encoding.ASCII.GetBytes(request);
        }
        public Byte[] ConvertHexToByte(string request)
        {
            return Enumerable.Range(0, request.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(request.Substring(x, 2), 16)).ToArray();

        }
        public Byte[] ConvertBase64ToByte(string request)
        {
            return Convert.FromBase64String(request);

        }
    }
}
