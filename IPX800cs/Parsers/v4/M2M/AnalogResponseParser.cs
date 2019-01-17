﻿namespace software.elendil.IPX800.Parsers.v4.M2M
{
    public class AnalogResponseParser : HeadedResponseParserBase, IInputResponseParser<string>
    {
        public string ParseResponse(string ipxResponse, int inputNumber)
        {
            var result = ExtractValue(ipxResponse, inputNumber);
            return result;
        }

        protected override string BuildRegexPatternString(int inputOutputNumber)
        {
            //TODO remplacer la concaténation par une interpolation de chaine
            return "A" + inputOutputNumber.ToString("D1") + "=([0-9\\.,]*)";
        }
    }
}