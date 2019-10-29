using System;
using System.Diagnostics;


namespace R5T.Caledonia.Default
{
    public class DefaultCommandLineInvocationOperator : ICommandLineInvocationOperator
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
