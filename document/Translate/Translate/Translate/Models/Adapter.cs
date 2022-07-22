using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate.Models
{
    public class Adapter : IInputData
    {
        private readonly OutputData _outputData;

        public Adapter(OutputData outputData)
        {
            _outputData = outputData;
        }

        public string SendRequestByteToString(string request)
        {
            return this.TranslateFromByteToString(request);
        }
        public string TranslateFromByteToString(string request)
        {
            string[] a = request.Split("-");
            List<byte> b = new List<byte>();
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    b.Add((byte)int.Parse(a[i].ToString()));
                }
            }
            catch (Exception e)
            {
                return "wrong data";
            }
            return Encoding.ASCII.GetString(b.ToArray());
        }
        public string SendRequestStringToHex(string request)
        {
            return this.TranslateFromStringToHex(request);
        }
        public string TranslateFromStringToHex(string request)
        {
            return Convert.ToHexString(_outputData.ConvertStringToByte(request));
        }

        public string SendRequestStringToBase64(string request)
        {
            return this.TranslateFromStringToBase64(request);
        }
        public string TranslateFromStringToBase64(string request)
        {
            return Convert.ToBase64String(_outputData.ConvertStringToByte(request));
        }
        public string SendRequestStringToByte(string request)
        {
            return this.TranslateFromStringToByte(request);
        }
        public string TranslateFromStringToByte(string request)
        {
            byte[] m = _outputData.ConvertStringToByte(request);
            string a = "";
            for (int i = 0; i < m.Length; i++)
            {
                a = a + m[i].ToString();
                if (i < m.Length - 1)
                {
                    a = a + "-";
                }
            }
            return a;
        }
        public string SendRequestHexToByte(string request)
        {
            return this.TranslateFromHexToByte(request);
        }
        public string TranslateFromHexToByte(string request)
        {
            byte[] m;
            try
            {
                m = _outputData.ConvertHexToByte(request);
            }
            catch (Exception e)
            {
                return "wrong data";
            }
            string a = "";
            for (int i = 0; i < m.Length; i++)
            {
                a = a + m[i].ToString();
                if (i < m.Length - 1)
                {
                    a = a + "-";
                }
            }
            return a;
        }
        public string SendRequestByteToHex(string request)
        {
            return TranslateFromByteToHex(request);
        }
        public string TranslateFromByteToHex(string request)
        {

            string[] a = request.Split("-");
            List<byte> b = new List<byte>();
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    b.Add((byte)int.Parse(a[i].ToString()));
                }
            }
            catch (Exception e)
            {
                return "wrong data";
            }
            return Convert.ToHexString(b.ToArray());
        }
        public string SendRequestHexToString(string request)
        {
            return this.TranslateFromHexToString(request);
        }
        public string TranslateFromHexToString(string request)
        {
            Byte[] myByte;
            try
            {
                myByte = Enumerable.Range(0, request.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(request.Substring(x, 2), 16)).ToArray();
            }
            catch(Exception e)
            {
                return "wrong data";
            }
            return Encoding.ASCII.GetString(myByte);
        }
        public string SendRequestBase64ToString(string request)
        {
            return this.TranslateFromBase64ToString(request);
        }
        public string TranslateFromBase64ToString(string request)
        {
            Byte[] myByte;
            try
            {
                myByte = Convert.FromBase64String(request);
            }catch(Exception)
            {
                return "wrong data";
            }
            return Encoding.ASCII.GetString(myByte);
        }
        public string SendRequestBase64ToByte(string request)
        {
            return this.TranslateFromBase64ToByte(request);
        }
        public string TranslateFromBase64ToByte(string request)
        {
            byte[] m;
            try
            {
                m = Convert.FromBase64String(request);
            }catch(Exception e)
            {
                return "wrong data";
            }
            
            string a = "";
            for (int i = 0; i < m.Length; i++)
            {
                a = a + m[i].ToString();
                if (i < m.Length - 1)
                {
                    a = a + "-";
                }
            }
            return a;
        }
        public string SendRequestByteToBase64(string request)
        {
            return this.TranslateFromByteToBase64(request);
        }
        public string TranslateFromByteToBase64(string request)
        {
            string[] a = request.Split("-");
            List<byte> b = new List<byte>();
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    b.Add((byte)int.Parse(a[i].ToString()));
                }
            }
            catch (Exception e)
            {
                return "Wrong data";
            }
            return Convert.ToBase64String(b.ToArray());
        }
        public string SendRequestHexToBase64(string request)
        {
            return TranslateFromHexToBase64(request);
        }
        public string TranslateFromHexToBase64(string request)
        {
            return TranslateFromByteToBase64(TranslateFromHexToByte(request));
        }
        public string SendRequestBase64ToHex(string request)
        {
            return TranslateFromBase64ToHex(request);
        }
        public string TranslateFromBase64ToHex(string request)
        {
            return TranslateFromByteToHex(TranslateFromBase64ToByte(request));
        }
    }
}
