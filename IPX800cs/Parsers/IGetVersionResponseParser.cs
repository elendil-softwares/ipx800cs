using software.elendil.IPX800.IO;

namespace software.elendil.IPX800.Parsers
{
    public interface IGetVersionResponseParser
    {
        string ParseResponse(string ipxResponse);
    }
}