using System;
namespace ComputerDetails
{
    public class Laptop: Computer
    {
        // #region Fields
        // int DisplaySize;
        // int BatteryVolt;
        // #endregion

        public int DisplaySize;
        public int BatteryVolt;

        
        

        public double LaptopPriceCalculation()
        
        {
            int ProcessorCost = 0;
            if(Processor == "i3"){}
            {
                ProcessorCost = 2500;
            }
            if(Processor == "i5"){}
            {
                ProcessorCost = 5000;
            }
            if(Processor == "i7"){}
            {
                ProcessorCost = 6500;
            }
            double LaptopPrice = ProcessorCost+ (RamSize *200) + (HardDiskSize * 1500)+(GraphicCard*2500)
            +(DisplaySize * 250) + (BatteryVolt * 20);

            return LaptopPrice;
        }
    }
}

// Laptop Price = Processor Cost + (RamSize * Ram Price) + (HardDiskSize * Hard Disk Price) + (GraphicCard * Graphic Card Price) + (Display Size* Display Price) + (BatteryVolt * Battery Volt Price);
//     Processor
//    Processor Cost
//     i3
//   2500
//     i5
//   5000
//     i7
//   6500
//   Ram price (per GB)
//   Hard disk (per TB)
//  Graphic Card (per GB)
//  Battery(per Volt)
//  Display(per inch)
//     200
//    1500
//    2500
//    20
//  250