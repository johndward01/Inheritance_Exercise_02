namespace Inheritance_Exercise_01;

public class Laptop : ComputerSystem
{
    public bool HasTouchScreen { get; set; }

    public void DisplaySystemInfo()
    {
        Console.WriteLine($"Processor: {Processor}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine($"OS: {OS}");
        Console.WriteLine($"Has a touch screen: {HasTouchScreen}");
    }

}
