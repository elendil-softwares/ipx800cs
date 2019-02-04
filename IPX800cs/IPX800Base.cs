﻿using software.elendil.IPX800.ActionsExecutors;
using software.elendil.IPX800.Contracts;
using software.elendil.IPX800.IO;

namespace software.elendil.IPX800
{
    public abstract class IPX800Base : IIPX800
    {       
        protected readonly ISetOutputExecutor SetOutputExecutor;
        protected readonly IGetOutputExecutor GetOutputExecutor;
        protected readonly IGetInputExecutor GetInputExecutor;
        protected readonly IGetAnalogInputExecutor GetAnalogInputExecutor;
        
        protected IPX800Base(Context context)
        {
            SetOutputExecutor = new SetOutputExecutor(context);
            GetOutputExecutor = new GetOutputExecutor(context);
            GetInputExecutor = new GetInputExecutor(context);
            GetAnalogInputExecutor = new GetAnalogInputExecutor(context);
        }

        public InputState GetInput(int inputNumber)
        {
            return GetInputExecutor.Execute(new Input
            {
                Number = inputNumber,
                Type = InputType.DigitalInput
            });
        }

        public double GetAnalogInput(int inputNumber)
        {
            return GetAnalogInputExecutor.Execute(new Input
            {
                Number = inputNumber,
                Type = InputType.AnalogInput
            });
        }

        public OutputState GetOutput(int outputNumber)
        {
            return GetOutputExecutor.Execute(new Output
            {
                Number = outputNumber,
                Type = OutputType.Output
            });
        }

        public bool SetOutput(int outputNumber, OutputState state)
        {
            return SetOutputExecutor.Execute(new Output
            {
                Number = outputNumber,
                Type = OutputType.Output,
                State = state
            });
        }

        public bool SetDelayedOutput(int outputNumber)
        {
            return SetOutputExecutor.Execute(new Output
            {
                Number = outputNumber,
                Type = OutputType.Output,
                State = OutputState.Active,
                IsDelayed = true
            });
        }        
    }
}