using software.elendil.IPX800.IO;

namespace software.elendil.IPX800.Commands.Builders.v4.Http
{
    public class IPX800v4GetOutputHttpCommandBuilder : IPX800v4HttpCommandBuilderBase, IGetOutputCommandBuilder
    {
        public string BuildCommandString(IPX800Output output)
        {
            return $"{baseRequest}{IPX800v4CommandStrings.GetOutput}";
        }
    }
}