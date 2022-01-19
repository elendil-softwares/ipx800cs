﻿using System.Text;
using IPX800cs.IO;

namespace IPX800cs.Commands.Builders.v3.M2M;

internal class IPX800V3SetOutputM2MCommandBuilder : ISetOutputCommandBuilder
{
    public Command BuildCommandString(Output output)
    {
        var command = new StringBuilder($"{IPX800v3M2MCommandStrings.SetOutput}{output.Number:D2}{(int) output.State}");

        if (output.IsDelayed && output.State == OutputState.Active)
        {
            command.Append(IPX800v3M2MCommandStrings.SetOutputDelayedSuffix);
        }

        return Command.CreateM2M(command.ToString());
    }
}