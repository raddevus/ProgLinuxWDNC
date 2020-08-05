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

            switch (args[0].ToLower()){
                case "os":{
                    Console.WriteLine($"OS : {Environment.OSVersion}");
                    break;
                }
                case "pwd":{
                    Console.WriteLine($"The current directory is: {Environment.CurrentDirectory}");
                    break;
                }
                case "cl":{
                    Console.WriteLine($"Command line was: {Environment.CommandLine}");
                    break;
                }
                case "sysdir":{
                    Console.WriteLine($"System dir: {Environment.SystemDirectory}");
                    break;
                }
                case "mname":{
                    Console.WriteLine($"Machine name: {Environment.MachineName}");
                    break;
                }
            }
        }
    }
}
