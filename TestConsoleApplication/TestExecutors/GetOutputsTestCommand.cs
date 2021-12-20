using System.Collections.Generic;
using System.Linq;
using IPX800cs.IO;
using TestConsoleApplication.Configuration;
using IPX800cs;

namespace TestConsoleApplication.TestExecutors;

internal class GetOutputsTestCommand : TestCommandBase
{
    public GetOutputsTestCommand(TestCase testCase, IIPX800 ipx800, LogFile logFile) : base(testCase, ipx800, logFile)
    {
    }

    protected override string ExecuteCommand()
    {
        Dictionary<int, OutputState> result = IPX800.GetOutputs();
        return string.Join(";", result.Select(x => x.Key + "=" + x.Value).ToArray());
    }
}