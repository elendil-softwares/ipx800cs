﻿namespace IPX800cs.Parsers.v5;

internal class IPX800V5GetAnalogInputResponseParser : IGetAnalogInputResponseParser
{
    public int ParseResponse(string ipxResponse, int inputNumber)
    {
        AnaResponse response = ipxResponse.ParseAna();
        return response.Value;
    }
}