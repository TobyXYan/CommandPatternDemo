using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternDemo
{
    public class Invoker
    {
        private ICommand _onCommand;
        private ICommand _offCommand;
        private ICommand _upCommand;
        private ICommand _downCommand;

        public Invoker(ICommand onCommand, ICommand offCommand, ICommand upCommand, ICommand downCommand)
        {
            _onCommand   = onCommand;
            _offCommand  = offCommand;
            _upCommand   = upCommand;
            _downCommand = downCommand;
        }

        public void TurnOnLight()
        {
            _onCommand.Execute();
        }

        public void ReverseOnLight()
        {
            _onCommand.UnExecute();
        }

        public void TurnOffLight()
        {
            _offCommand.Execute();
        }

        public void ReverseOffLight()
        {
            _offCommand.UnExecute();
        }

        public void TurnUpLight()
        {
            _upCommand.Execute();
        }

        public void ReverseUpLight()
        {
            _upCommand.UnExecute();
        }

        public void TurnDownLight()
        {
            _downCommand.Execute();
        }

        public void ReverseDownLight()
        {
            _downCommand.UnExecute();
        }
    }
}
