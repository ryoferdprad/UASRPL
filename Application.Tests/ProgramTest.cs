// ProgramTest.cs

using System;

namespace Application.Tests
{
    public class FakeConsole : IConsole
    {
        private readonly string[] _inputs;
        private int _currentInputIndex = 0;
        public string Output { get; private set; } = "";

        public FakeConsole(string[] inputs)
        {
            _inputs = inputs;
        }

        public string ReadLine()
        {
            string input = _inputs[_currentInputIndex];
            _currentInputIndex++;
            return input;
        }

        public void WriteLine(string value)
        {
            Output += value + "\n";
        }
    }
}
