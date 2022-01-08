﻿using IPX800cs.Exceptions;
using IPX800cs.IO;
using Moq;
using Xunit;

namespace IPX800cs.Test;

public class IPX800v2Test : IPX800BaseTest
{
    public IPX800v2Test()
    {
        SetupMocks();
        _ipx800 = new IPX800V2(IPX800Protocol.Http, _commandFactory.Object, _commandSender.Object, _responseParserFactory.Object);
    }

    public override void GetInputsTest()
    {
        Assert.Throws<IPX800NotSupportedCommandException>(() => _ipx800.GetInputs(InputType.DigitalInput));
    }

    public override void GetAnalogInputsTest()
    {
        //Arrange
        _ipx800 = new IPX800V2(IPX800Protocol.Http, _commandFactory.Object, _commandSender.Object, _responseParserFactory.Object);
        var analogInputType = AnalogInputType.AnalogInput;
            
        //Act
        _ipx800.GetAnalogInputs(analogInputType);
            
        //Assert
        _commandFactory.Verify(_ => _.CreateGetAnalogInputsCommand(It.IsAny<AnalogInputType>()), Times.Once());
        _commandSender.Verify(_ => _.ExecuteCommand(It.IsAny<string>()), Times.Once);
        _responseParserFactory.Verify(_ => _.GetAnalogInputsParser(It.IsAny<IPX800Protocol>(), It.IsAny<AnalogInputType>()), Times.Once);
    }
    
    [Fact]
    public void GetM2MAnalogInputsTest()
    {
        //Arrange
        _ipx800 = new IPX800V2(IPX800Protocol.M2M, _commandFactory.Object, _commandSender.Object, _responseParserFactory.Object);
        var analogInputType = AnalogInputType.AnalogInput;
            
        //Act
        _ipx800.GetAnalogInputs(analogInputType);
            
        //Assert
        _commandFactory.Verify(_ => _.CreateGetAnalogInputCommand(It.IsAny<AnalogInput>()), Times.Exactly(2));
        _commandSender.Verify(_ => _.ExecuteCommand(It.IsAny<string>()), Times.Exactly(2));
        _responseParserFactory.Verify(_ => _.GetAnalogInputParser(IPX800Protocol.M2M, It.IsAny<AnalogInputType>()), Times.Once);
    }

    public override void GetOutputsTest()
    {
        Assert.Throws<IPX800NotSupportedCommandException>(() => _ipx800.GetOutputs(OutputType.Output));
    }
}