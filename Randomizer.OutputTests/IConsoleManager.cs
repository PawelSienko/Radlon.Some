﻿namespace Randomizer.OutputTests
{
    public interface IConsoleManager
    {
        void PrintHeader();

        void PrintFooter();

        void PrintLine(string line);
    }
}