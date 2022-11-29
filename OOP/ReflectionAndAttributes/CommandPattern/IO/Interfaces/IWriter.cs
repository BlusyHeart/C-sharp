using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.IO.Interfaces
{
    public interface IWriter
    {
        void Write(string command);

        void WriteLine(string command);
    }
}
