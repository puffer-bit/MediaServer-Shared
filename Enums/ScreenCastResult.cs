using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Enums
{
    public enum ScreenCastResult
    {
        NoError = 0,
        InitFailed = 1,
        SourceError = 2,
        NotInitialized = 3,
        InternalError = 4
    }
}
