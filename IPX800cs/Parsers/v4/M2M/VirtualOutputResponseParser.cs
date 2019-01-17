﻿using software.elendil.IPX800.IO;

namespace software.elendil.IPX800.Parsers.v4.M2M
{
    public class VirtualOutputResponseParser : NonHeadedResponseParserBase, IOutputResponseParser<OutputState>
    {
        public OutputState ParseResponse(string ipxResponse, int outputNumber)
        {
            ipxResponse = ipxResponse.Replace("VO=", "");
            string result = ExtractValue(ipxResponse, outputNumber);
            return (OutputState) System.Enum.Parse(typeof(OutputState), result);
        }
    }
}