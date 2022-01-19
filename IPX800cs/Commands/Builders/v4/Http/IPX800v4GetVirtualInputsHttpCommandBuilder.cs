namespace IPX800cs.Commands.Builders.v4.Http;

internal class IPX800V4GetVirtualInputsHttpCommandBuilder : IGetInputsCommandBuilder
{
    public Command BuildCommandString()
    {
        return Command.CreateGet($"{IPX800v4CommandStrings.HttpBaseRequest}{IPX800v4CommandStrings.GetVirtualInput}");
    }
}