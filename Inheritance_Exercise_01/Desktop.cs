namespace Inheritance_Exercise_01;

public class Desktop : ComputerSystem
{
    public bool HasExternalKeyboard { get; set; }

    public void DisplaySystemInfo()
    {
        Console.WriteLine($"Processor: {Processor}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine($"OS: {OS}");
        Console.WriteLine($"Has an external Keyboard: {HasExternalKeyboard}");
    }
    
}
