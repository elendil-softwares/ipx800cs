using software.elendil.IPX800.IO;
using software.elendil.IPX800.Parsers.v4.Http;
using Xunit;

namespace IPX800cs.Test.Parsers.v4.Http
{
    public class IPX800v4GetVirtualInputHttpResponseParserTest
    {
        [Fact]
        public void GivenActiveInput_ParseResponse_ReturnsActive()
        {
            //Arrange
            var parser = new IPX800v4GetVirtualInputHttpResponseParser();

            //Act
            InputState response = parser.ParseResponse(JsonResponse, 8);
            
            //Assert
            Assert.Equal(InputState.Active, response);
        }

        

        [Fact]
        public void GivenInactiveInput_ParseResponse_ReturnsInactive()
        {
            //Arrange
            var parser = new IPX800v4GetVirtualInputHttpResponseParser();

            //Act
            InputState response = parser.ParseResponse(JsonResponse, 2);
            
            //Assert
            Assert.Equal(InputState.Inactive, response);
        }
        
        public const string JsonResponse = @"{
    ""product"": ""IPX800_V4"",
    ""status"": ""Success"",
    ""VI1"": 0,
    ""VI2"": 0,
    ""VI3"": 0,
    ""VI4"": 0,
    ""VI5"": 0,
    ""VI6"": 0,
    ""VI7"": 0,
    ""VI8"": 1,
    ""VI9"": 1,
    ""VI10"": 0,
    ""VI11"": 0,
    ""VI12"": 0,
    ""VI13"": 0,
    ""VI14"": 0,
    ""VI15"": 0,
    ""VI16"": 1,
    ""VI17"": 0,
    ""VI18"": 0,
    ""VI19"": 0,
    ""VI20"": 0,
    ""VI21"": 0,
    ""VI22"": 0,
    ""VI23"": 0,
    ""VI24"": 0,
    ""VI25"": 0,
    ""VI26"": 0,
    ""VI27"": 0,
    ""VI28"": 0,
    ""VI29"": 0,
    ""VI30"": 0,
    ""VI31"": 0,
    ""VI32"": 0,
    ""VI33"": 0,
    ""VI34"": 0,
    ""VI35"": 0,
    ""VI36"": 0,
    ""VI37"": 0,
    ""VI38"": 0,
    ""VI39"": 0,
    ""VI40"": 0,
    ""VI41"": 0,
    ""VI42"": 0,
    ""VI43"": 0,
    ""VI44"": 0,
    ""VI45"": 0,
    ""VI46"": 0,
    ""VI47"": 0,
    ""VI48"": 0,
    ""VI49"": 0,
    ""VI50"": 0,
    ""VI51"": 0,
    ""VI52"": 0,
    ""VI53"": 0,
    ""VI54"": 0,
    ""VI55"": 0,
    ""VI56"": 0,
    ""VI57"": 0,
    ""VI58"": 0,
    ""VI59"": 0,
    ""VI60"": 0,
    ""VI61"": 0,
    ""VI62"": 0,
    ""VI63"": 0,
    ""VI64"": 0,
    ""VI65"": 0,
    ""VI66"": 0,
    ""VI67"": 0,
    ""VI68"": 0,
    ""VI69"": 0,
    ""VI70"": 0,
    ""VI71"": 0,
    ""VI72"": 0,
    ""VI73"": 0,
    ""VI74"": 0,
    ""VI75"": 0,
    ""VI76"": 0,
    ""VI77"": 0,
    ""VI78"": 0,
    ""VI79"": 0,
    ""VI80"": 0,
    ""VI81"": 0,
    ""VI82"": 0,
    ""VI83"": 0,
    ""VI84"": 0,
    ""VI85"": 0,
    ""VI86"": 0,
    ""VI87"": 0,
    ""VI88"": 0,
    ""VI89"": 0,
    ""VI90"": 0,
    ""VI91"": 0,
    ""VI92"": 0,
    ""VI93"": 0,
    ""VI94"": 0,
    ""VI95"": 0,
    ""VI96"": 0,
    ""VI97"": 0,
    ""VI98"": 0,
    ""VI99"": 0,
    ""VI100"": 0,
    ""VI101"": 0,
    ""VI102"": 0,
    ""VI103"": 0,
    ""VI104"": 0,
    ""VI105"": 0,
    ""VI106"": 0,
    ""VI107"": 0,
    ""VI108"": 0,
    ""VI109"": 0,
    ""VI110"": 0,
    ""VI111"": 0,
    ""VI112"": 0,
    ""VI113"": 0,
    ""VI114"": 0,
    ""VI115"": 0,
    ""VI116"": 0,
    ""VI117"": 0,
    ""VI118"": 0,
    ""VI119"": 0,
    ""VI120"": 0,
    ""VI121"": 0,
    ""VI122"": 0,
    ""VI123"": 0,
    ""VI124"": 0,
    ""VI125"": 0,
    ""VI126"": 0,
    ""VI127"": 0,
    ""VI128"": 0
}";
    }
}