using Inheritance_Exercise_01;

// TODO: Create a base class called ComputerSystem
// TODO: Create 4 properties called Processor, RAM, GPU, and OS 

// TODO: Create 3 derived classes called Desktop, Laptop, and Server
// TODO: Give each derived class 1 unique property (i.e. HasTouchScreen)
// TODO: Create a method that creatively displays the derived classes information called DisplaySystemInfo()

// TODO: Create objects for each of the derived classes and give their properties values

var desktop = new Desktop();
desktop.Processor = "AMD Ryzen 5 7900X";
desktop.RAM = "CORSAIR Vengeance DDR5 32GB";
desktop.GPU = "AMD Radeon™ RX 6950 XT";
desktop.OS = "Windows 11 Home";
desktop.HasExternalKeyboard = true;

var laptop = new Laptop()
{
    Processor = "5.1 GHz amd_ryzen_7",
    RAM = "16 GB DDR5",
    GPU = "NVIDIA GeForce RTX 4050",
    OS = "Windows 11 Home",
    HasTouchScreen = true
};

var server = new Server()
{
    Processor = "AMD EPYC 9654 2.4 GHz",
    RAM = "v-Color 32GB ECC SO-DIMM DDR4 2666MHz",
    GPU = "Nvidia Quadro RTX-5000 16GB GDDR6 ECC",
    OS = "Linux",
    HasDumbTerminal = true
};

// TODO: Creatively display the information to the console
Console.WriteLine(nameof(desktop).ToUpper());
desktop.DisplaySystemInfo();

Console.WriteLine();

Console.WriteLine(nameof(laptop).ToUpper());
laptop.DisplaySystemInfo();

Console.WriteLine();

Console.WriteLine(nameof(server).ToUpper());
server.DisplaySystemInfo();