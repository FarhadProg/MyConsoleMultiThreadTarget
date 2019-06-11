using System;
using System.Collections.Generic;
using System.Text;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace MyConsoleMultiThreadTarget
{
    class MyTarget: AsyncTaskTarget
    {
        protected override Task WriteAsyncTask()
        {

        }
    }
}
