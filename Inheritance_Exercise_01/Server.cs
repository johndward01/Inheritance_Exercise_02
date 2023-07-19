namespace Inheritance_Exercise_01;

public class Server : ComputerSystem
{
    public bool HasDumbTerminal { get; set; }

    public void DisplaySystemInfo()
    {
        Console.WriteLine($"Processor: {Processor}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine($"OS: {OS}");
        Console.WriteLine($"Is accessed with a dumb terminal: {HasDumbTerminal}");
    }
}
