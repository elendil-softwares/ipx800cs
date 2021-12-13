using System;
using IPX800cs.Commands.Builders.v3.Http;
using IPX800cs.Exceptions;
using IPX800cs.IO;
using IPX800cs.Version;

namespace IPX800cs.Commands.Builders.v3
{
    internal class IPX800v3HttpCommandBuilderFactory : ICommandBuilderFactory
    {
        public ISetOutputCommandBuilder GetSetOutputCommandBuilder(Context context, Output output)
        {
            if (output.Type == OutputType.Output)
            {
                return new IPX800v3SetOutputHttpCommandBuilder();
            }
            
            throw new IPX800InvalidContextException($"Output type '{output.Type}' is not valid");
        }

        public IGetOutputCommandBuilder GetGetOutputCommandBuilder(Context context, Output output)
        {
            if (output.Type != OutputType.Output)
            {
                throw new IPX800InvalidContextException($"Output type '{output.Type}' is not valid");
            }

            if (VersionChecker.IsLegacy(context.FirmwareVersion))
            {
                throw new NotImplementedException();
            }
            else
            {
                return new IPX800v3GetOutputHttpCommandBuilder();
            }
        }

        public IGetOutputsCommandBuilder GetGetOutputsCommandBuilder(Context context, Output output)
        {
            if (output.Type != OutputType.Output)
            {
                throw new IPX800InvalidContextException($"Output type '{output.Type}' is not valid");
            }
            
            if (VersionChecker.IsLegacy(context.FirmwareVersion))
            {
                throw new NotImplementedException();
            }
            else
            {
                return new IPX800v3GetOutputsHttpCommandBuilder();
            }
        }

        public IGetInputCommandBuilder GetGetInputCommandBuilder(Context context, Input input)
        {
            switch (input.Type)
            {
                case InputType.AnalogInput:
                    return VersionChecker.IsLegacy(context.FirmwareVersion) ? throw new NotImplementedException() : new IPX800v3GetAnalogInputHttpCommandBuilder();

                case InputType.DigitalInput:
                    return VersionChecker.IsLegacy(context.FirmwareVersion) ? throw new NotImplementedException() : new IPX800v3GetInputHttpCommandBuilder();

                default:
                    throw new IPX800InvalidContextException($"Input type '{input.Type}' is not valid");
            }
        }

        public IGetInputsCommandBuilder GetGetInputsCommandBuilder(Context context, Input input)
        {
            if (input.Type != InputType.DigitalInput)
            {
                throw new IPX800InvalidContextException($"Input type '{input.Type}' is not valid");
            }
            
            if (VersionChecker.IsLegacy(context.FirmwareVersion))
            {
                throw new NotImplementedException();
            }
            else
            {
                return new IPX800v3GetInputsHttpCommandBuilder();
            }
        }

        public IGetVersionCommandBuilder GetGetVersionCommandBuilder(Context context)
        {
            if (VersionChecker.IsLegacy(context.FirmwareVersion))
            {
                throw new NotImplementedException();
            }
            else
            {
                return new IPX800v3GetVersionHttpCommandBuilder();
            }
        }
    }
}