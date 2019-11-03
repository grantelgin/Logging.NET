using Logging.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    /// <summary>
    /// Considering using this as a logging API that handles logging framework details (serilog and the various sinks, nLog, custom).
    /// The platform-specific loggers would inherit this rather than <see cref="ILogger"/>.
    /// </summary>
    public class Logger :ILogger
    {
        
    }
}
