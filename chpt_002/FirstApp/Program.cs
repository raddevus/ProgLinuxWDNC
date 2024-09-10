namespace FirstApp;

class Program
{
    static void Main(string[] args)
    {
        String output = args[0];
        Console.WriteLine(output);
        var argIndex = 0;
        foreach(String s in args){
            Console.WriteLine($"args[{argIndex}]: {s}");
            argIndex++;
        }
        Console.WriteLine("Hello, World!");
    }
}
