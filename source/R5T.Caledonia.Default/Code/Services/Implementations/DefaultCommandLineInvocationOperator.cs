using System;
using System.Diagnostics;

using R5T.T0064;


namespace R5T.Caledonia.Default
{
    [ServiceImplementationMarker]
    public class DefaultCommandLineInvocationOperator : ICommandLineInvocationOperator, IServiceImplementation
    {
        public int Run(string command, string arguments, DataReceivedEventHandler receiveOutputData, DataReceivedEventHandler receiveErrorData)
        {
            var exitCode = CommandLineInvocationRunner.Run(command, arguments, receiveOutputData, receiveErrorData);
            return exitCode;
        }

        public CommandLineInvocationResult Run(CommandLineInvocation invocation)
        {
            var result = CommandLineInvocationRunner.Run(invocation);
            return result;
        }
    }
}
