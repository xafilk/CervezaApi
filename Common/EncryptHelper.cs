using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerveza.Common
{
    public static class EncryptHelper
    {
        /// <summary>
        /// Encode from normal text to Base64 string format
        /// </summary>
        /// <param name="value">string to Encode</param>
        /// <returns></returns>
        public static string EncodeStringToBase64String(string value)
        {
            byte[] data = ASCIIEncoding.ASCII.GetBytes(value);
            return Convert.ToBase64String(data);
        }

        /// <summary>
        /// Decode from base64 string format to normal string
        /// </summary>
        /// <param name="value">string to decode</param>
        /// <returns></returns>
        public static string DecodeBase64StringToString(string value)
        {
            byte[] data = Convert.FromBase64String(value);
            return ASCIIEncoding.ASCII.GetString(data);
        }
    }
}
