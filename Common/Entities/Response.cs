using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerveza.Common.Entities
{
    public class Response<T>
    {
        /// <summary>
        /// Represend the succes of the request
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// And Status code for the request (Ex: 200 = ok)
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Message Response Value
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Generic info with the data requested by the Client (if no data needed set to int )
        /// </summary>
        public T Object { get; set; }
    }
}
