using System;
using System.IO;

namespace fileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("test.txt","Hello World!");
        }
    }
}
