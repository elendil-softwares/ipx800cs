using System.Collections.Generic;
using IPX800cs.IO;
using IPX800cs.Parsers.v4.M2M;
using Xunit;

namespace IPX800cs.Test.Parsers.v4.M2M
{
    public class IPX800v4GetVirtualInputsM2MResponseParserTest
    {
        private const string HeadedResponse = "VI=0&0&0&0&0&0&0&1&1&0&0&0&0&0&0&1&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0&0";
        private const string Response = "00000001100000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000\r\n";

        [Theory]
        [InlineData(HeadedResponse)]
        [InlineData(Response)]
        public void GivenValidResponse_ParseResponse_ReturnsExpectedResponse(string ipxResponse)
        {
            //Arrange
            var parser = new IPX800v4GetVirtualInputsM2MResponseParser();
            var expectedResponse = new Dictionary<int, InputState>
            {
                {1, InputState.Inactive},
                {2, InputState.Inactive},
                {3, InputState.Inactive},
                {4, InputState.Inactive},
                {5, InputState.Inactive},
                {6, InputState.Inactive},
                {7, InputState.Inactive},
                {8, InputState.Active},
                {9, InputState.Active},
                {10, InputState.Inactive},
                {11, InputState.Inactive},
                {12, InputState.Inactive},
                {13, InputState.Inactive},
                {14, InputState.Inactive},
                {15, InputState.Inactive},
                {16, InputState.Active},
                {17, InputState.Inactive},
                {18, InputState.Inactive},
                {19, InputState.Inactive},
                {20, InputState.Inactive},
                {21, InputState.Inactive},
                {22, InputState.Inactive},
                {23, InputState.Inactive},
                {24, InputState.Inactive},
                {25, InputState.Inactive},
                {26, InputState.Inactive},
                {27, InputState.Inactive},
                {28, InputState.Inactive},
                {29, InputState.Inactive},
                {30, InputState.Inactive},
                {31, InputState.Inactive},
                {32, InputState.Inactive},
                {33, InputState.Inactive},
                {34, InputState.Inactive},
                {35, InputState.Inactive},
                {36, InputState.Inactive},
                {37, InputState.Inactive},
                {38, InputState.Inactive},
                {39, InputState.Inactive},
                {40, InputState.Inactive},
                {41, InputState.Inactive},
                {42, InputState.Inactive},
                {43, InputState.Inactive},
                {44, InputState.Inactive},
                {45, InputState.Inactive},
                {46, InputState.Inactive},
                {47, InputState.Inactive},
                {48, InputState.Inactive},
                {49, InputState.Inactive},
                {50, InputState.Inactive},
                {51, InputState.Inactive},
                {52, InputState.Inactive},
                {53, InputState.Inactive},
                {54, InputState.Inactive},
                {55, InputState.Inactive},
                {56, InputState.Inactive},
                {57, InputState.Inactive},
                {58, InputState.Inactive},
                {59, InputState.Inactive},
                {60, InputState.Inactive},
                {61, InputState.Inactive},
                {62, InputState.Inactive},
                {63, InputState.Inactive},
                {64, InputState.Inactive},
                {65, InputState.Inactive},
                {66, InputState.Inactive},
                {67, InputState.Inactive},
                {68, InputState.Inactive},
                {69, InputState.Inactive},
                {70, InputState.Inactive},
                {71, InputState.Inactive},
                {72, InputState.Inactive},
                {73, InputState.Inactive},
                {74, InputState.Inactive},
                {75, InputState.Inactive},
                {76, InputState.Inactive},
                {77, InputState.Inactive},
                {78, InputState.Inactive},
                {79, InputState.Inactive},
                {80, InputState.Inactive},
                {81, InputState.Inactive},
                {82, InputState.Inactive},
                {83, InputState.Inactive},
                {84, InputState.Inactive},
                {85, InputState.Inactive},
                {86, InputState.Inactive},
                {87, InputState.Inactive},
                {88, InputState.Inactive},
                {89, InputState.Inactive},
                {90, InputState.Inactive},
                {91, InputState.Inactive},
                {92, InputState.Inactive},
                {93, InputState.Inactive},
                {94, InputState.Inactive},
                {95, InputState.Inactive},
                {96, InputState.Inactive},
                {97, InputState.Inactive},
                {98, InputState.Inactive},
                {99, InputState.Inactive},
                {100, InputState.Inactive},
                {101, InputState.Inactive},
                {102, InputState.Inactive},
                {103, InputState.Inactive},
                {104, InputState.Inactive},
                {105, InputState.Inactive},
                {106, InputState.Inactive},
                {107, InputState.Inactive},
                {108, InputState.Inactive},
                {109, InputState.Inactive},
                {110, InputState.Inactive},
                {111, InputState.Inactive},
                {112, InputState.Inactive},
                {113, InputState.Inactive},
                {114, InputState.Inactive},
                {115, InputState.Inactive},
                {116, InputState.Inactive},
                {117, InputState.Inactive},
                {118, InputState.Inactive},
                {119, InputState.Inactive},
                {120, InputState.Inactive},
                {121, InputState.Inactive},
                {122, InputState.Inactive},
                {123, InputState.Inactive},
                {124, InputState.Inactive},
                {125, InputState.Inactive},
                {126, InputState.Inactive},
                {127, InputState.Inactive},
                {128, InputState.Inactive}
            };

            //Act
            var response = parser.ParseResponse(ipxResponse);
            
            //Assert
            Assert.Equal(expectedResponse, response);
        }
    }
}