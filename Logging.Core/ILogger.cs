using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Core
{
    public interface ILogger
    {
        /// <summary>
        /// These entries can indicate which features are used most by end users.
        /// </summary>
        /// <param name="logDetail"></param>
        void WriteUsage(ILogDetail logDetail);
        /// <summary>
        /// These entries can identify slow areas in our code or could be used to analyze performance in different client environments.
        /// </summary>
        /// <param name="logDetail"></param>
        void WritePerformance(ILogDetail logDetail);
        /// <summary>
        /// These entries indicate errors that occur. We can use these entries to identify which errors occur the most, or identify errors that are one-off occurences.
        /// These entries can help us prioritize bug fixes and just as importantly, stop "fire-fighting" the latest urgent issue. (we can quickly spot issues that have only occured once, by this user only and not waste time investigating code issues)
        /// </summary>
        /// <param name="logDetail"></param>
        void WriteError(ILogDetail logDetail);
        /// <summary>
        /// More verbose entries for debug sessions only. These will not get logged in typical performance use. Only when "diagnostic mode" is enabled.
        /// </summary>
        /// <param name="logDetail"></param>
        void WriteDiagnostic(ILogDetail logDetail);

    }
}
