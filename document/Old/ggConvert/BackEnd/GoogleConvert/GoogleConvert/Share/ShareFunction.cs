using System.Text;

namespace GoogleConvert.Share
{
    public class ShareFunction
    {
        public static string ConvertArrByteToString(byte[] bytes)
        {
            if (bytes.Length == 0)
                return null;
            else
            {
                StringBuilder strBuilder = new StringBuilder();
                foreach (byte b in bytes)
                    strBuilder.Append(b.ToString() + " ");
                return strBuilder.ToString().Trim();
            }
        }
    }
}
