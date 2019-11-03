using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Core
{
    public interface ILogDetail
    {
        DateTime TimeStamp { get; }
        string Message { get; }
        string ProductName { get; }
        string NameOfAssembly { get; }
        string HostName { get; }
        string UserName { get; }
        /// <summary>
        /// Only for performance entries.
        /// </summary>
        long? ElapsedMilliseconds { get; set; }  
        /// <summary>
        /// The exception for error logging
        /// </summary>
        Exception Exception { get; set; }  
        /// <summary>
        /// Optional client facing ErrorID that can be used to hide stack trace, etc in error messages.
        /// Use this ID to search the error log for full details.  
        /// </summary>
        string ClientFacingErrorId { get; }
    }
}
