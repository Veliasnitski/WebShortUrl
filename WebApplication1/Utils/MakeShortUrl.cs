using ICSharpCode.SharpZipLib.Checksum;
using System;
using System.Text;

namespace ShortUrl.Utils
{
    public class MakeShortUrl
    {
        readonly string shortHash;
        public MakeShortUrl(string url)
        {
            shortHash = GetHashAdler32(url);
        }
        private string GetHashAdler32(string url)
        {
            byte[] buff = Encoding.Default.GetBytes(url);
            Adler32 adler = new Adler32();
            adler.Reset();
            adler.Update(buff);
            return Convert.ToString(adler.Value, 16);
        }

        public string GetShortUrl()
        {
            return shortHash;
        }
        public override string ToString()
        {
            return GetShortUrl();
        }
    }
}
