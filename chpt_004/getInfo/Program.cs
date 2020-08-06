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
                case "ostime":{
                    Console.WriteLine($"System has been running for {Environment.TickCount64/1000/60f} minutes.");
                    break;
                }
                case "version":{
                    Console.WriteLine($"runtime version {Environment.Version}");
                    break;
                }
                case "ws":{
                    Console.WriteLine($"This process is using {Environment.WorkingSet:N0} bytes of memory.");
                    break;
                }
                case "getvar":{
                    if (args.Length > 1){
                        var environValue = Environment.GetEnvironmentVariable(args[1].ToUpper());
                        if (environValue != null){
                            Console.WriteLine($"{environValue}");
                        }
                        else{
                            Console.WriteLine($"The environment does not have a definition for {args[1].ToUpper()}.");
                        }
                    }
                    else{
                        Console.WriteLine("You must provide an environment variable name that you want to retrieve.");
                    }
                    break;
                }
                case "getpath":{
                    var specFolders = Enum.GetValues(typeof(Environment.SpecialFolder));
                    foreach (Environment.SpecialFolder s in specFolders){
                        var folderPath = Environment.GetFolderPath(s);
                        if (folderPath != String.Empty){
                            Console.WriteLine($"[{s}] --> {folderPath}");
                        }
                    }
                    break;
                }
                case "getdrive":{
                    foreach (String s in Environment.GetLogicalDrives()){
                        Console.WriteLine($"{s}");
                    }
                    break;
                }
            }
        }
    }
}
