// See https://aka.ms/new-console-template for more information
using ComputerDetails;
Console.WriteLine("Computer Details");

Console.WriteLine("Enter your Choice : 1.Desktop   and   2.Laptop");
int choice = Int32.Parse(Console.ReadLine());


switch (choice)
{
    case 1:{
        Desktop dObj = new Desktop();
        Console.Write("Enter the processor name (i3 or i5 or i7)");
        dObj.Processor = Console.ReadLine();

        Console.Write("Enter Ram Size: ");
        dObj.RamSize =Int32.Parse(Console.ReadLine());
        Console.Write("Enter Hard Disk Size: ");
        dObj.HardDiskSize =Int32.Parse(Console.ReadLine());
        Console.Write("Enter Graphic Card: ");
        dObj.GraphicCard =Int32.Parse(Console.ReadLine());
        Console.Write("Enter Monitor Size: ");
        dObj.MoniterSize =Int32.Parse(Console.ReadLine());
        Console.Write("Enter Power Volt Supply: ");
        dObj.PowerSupplyVolt =Int32.Parse(Console.ReadLine());

        
    

        Console.WriteLine("Desktop price is " + dObj.DesktopPriceCalculation());

        break;
    }

    case 2:{
        Laptop lObj = new Laptop();
        Console.Write("Enter the processor name (i3 or i5 or i7)");
        lObj.Processor = Console.ReadLine();

        Console.Write("Enter Ram Size: ");
        lObj.RamSize =Int32.Parse(Console.ReadLine());
        Console.Write("Enter Hard Disk Size: ");
        lObj.HardDiskSize =Int32.Parse(Console.ReadLine());
        Console.Write("Enter Graphic Card: ");
        lObj.GraphicCard =Int32.Parse(Console.ReadLine());
        Console.Write("Enter Monitor Size: ");
        lObj.DisplaySize =Int32.Parse(Console.ReadLine());
        Console.Write("Enter Power Volt Supply: ");
        lObj.BatteryVolt =Int32.Parse(Console.ReadLine());

        Console.WriteLine("Desktop price is " + lObj.LaptopPriceCalculation());
        break;
    }

        default:{
            Console.WriteLine("Invalid Choice");
            break;
        }


}