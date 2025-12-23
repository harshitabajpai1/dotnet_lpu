using System;
namespace ComputerDetails
{
    public class Desktop: Computer
    {
        public int MoniterSize;
        public int PowerSupplyVolt;

        public double DesktopPriceCalculation()
        
        {
            int ProcessorCost = 0;
            if(Processor == "i3"){}
            {
                ProcessorCost = 1500;
            }
            if(Processor == "i5"){}
            {
                ProcessorCost = 3000;
            }
            if(Processor == "i7"){}
            {
                ProcessorCost = 4500;
            }
            double DesktopPrice = ProcessorCost+ (RamSize *200) + (HardDiskSize * 1500)+(GraphicCard*2500)
            +(PowerSupplyVolt * 20) + (MoniterSize * 250);

            return DesktopPrice;
        }
    }
}

// Formula 1:
// Desktop Price = Processor Cost + (RamSize * Ram Price) + (HardDiskSize * Hard Disk Price) + (GraphicCard * Graphic Card Price) + (MonitorSize * Monitor Price) + (PowerSupplyVolt * Power Supply Volt Price);
//     Processor
//    Processor Cost
//     i3
//   1500
//     i5
//   3000
//     i7
//   4500
//    Ram price (per GB)
//   Hard disk (per TB)
//   Graphic Card (per GB)
//   Power supply (per Volt)
//   Monitor (per inch)
//     200
//    1500
//    2500
//    20
//  250