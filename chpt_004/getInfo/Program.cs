using System;

namespace getInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1){
                Console.WriteLine("Please provide 1 argument to indicate the command you want to run.\nUsage: getInfo <command-name>");
                return;
            }

            switch (args[0]){
                case "os":{
                    Console.WriteLine($"OS : {Environment.OSVersion}");
                    break;
                }

            }
        }
    }
}
