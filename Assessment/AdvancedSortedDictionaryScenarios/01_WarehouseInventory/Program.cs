
using System;
using Services;
using Domain;

class Program
{
    static void Main()
    {
        Console.WriteLine("01_WarehouseInventory - Boilerplate");
        ManagementService service = new ManagementService();

        // TODO: Create entity
        // TODO: Add entity
        // TODO: Trigger custom exceptions
        // TODO: Display sorted results

        try
        {
            //Creating entity
            PrimaryEntity pObj1 = new PrimaryEntity
            {
                PriorityOrKey = 1001
            };
            PrimaryEntity pObj2 = new PrimaryEntity
            {
                PriorityOrKey = 1002
            };
            PrimaryEntity pObj3 = new PrimaryEntity
            {
                PriorityOrKey = 1003
            };
            PrimaryEntity pObj4 = new PrimaryEntity
            {
                PriorityOrKey = 1004
            };

            //Adding entity
            service.AddEntity(pObj1);
            service.AddEntity(pObj2);
            service.AddEntity(pObj3);
            service.AddEntity(pObj4);

            //Trigger CustomException
            service.RemoveEntity(20);

            //get all the details
            foreach(var item in service.GetAll())
            {
                Console.WriteLine($"{item.PriorityOrKey}");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }
}
