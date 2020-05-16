using System.Collections.Generic;
using System.Linq;
using IPX800cs.IO;

namespace IPX800cs.Parsers.v4.Http
{
    internal class IPX800v4GetVirtualInputsHttpResponseParser : IInputsResponseParser
    {
        public Dictionary<int, InputState> ParseResponse(string ipxResponse)
        {
            Dictionary<int, int> inputStates = JsonParser.ParseCollection(ipxResponse, "VI");
            return inputStates.ToDictionary(item => item.Key, item => (InputState) item.Value);
        }
    }
}