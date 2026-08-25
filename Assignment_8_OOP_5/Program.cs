namespace Assignment_8_OOP_5;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question1
        // a) What is Abstraction in Object-Oriented Programming?
        // => hiding complex implementation details and showing only the essential features of an object to the user.

        // b)  Why is abstraction considered one of the four pillars of OOP?
        // => It reduces system complexity, increases code reusability
        #endregion

        #region Question2
        // a) What is the difference between an Abstract Class and an Interface?
        // => An Abstract Class can contain both fully implemented methods and abstract methods, An Interface containing only method signatures without implementation or fields.

        // b)  When would you choose an Interface instead of an Abstract Class?
        // => when you want to define a common behavior that multiple unrelated classes must implement.

        // c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
        // => A class cannot inherit from multiple abstract classes. However, it can implement multiple interfaces.
        #endregion

        #region Question3
        DeliveryAddress defAddress = new DeliveryAddress("Cairo", "Tahrir", 15);

        StandardShipment s1 = new StandardShipment("SH001", "Laptop", 3m, 80m, defAddress);

        ExpressShipment e1 = new ExpressShipment("SH002", "Mobile Phone", 2m, 60m, defAddress, 30m);

        InternationalShipment i1 = new InternationalShipment("SH003", "Television", 8m, 120m, defAddress, "Germany", 100m);

        DeliveryCenter center = new DeliveryCenter();
        center.CenterName = "Delivery Center";
        center.AddShipment(s1);
        center.AddShipment(e1);
        center.AddShipment(i1);

        Console.WriteLine("========================================");
        Console.WriteLine(center.CenterName);
        Console.WriteLine("========================================\n");

        s1.PrintShipment();
        Console.WriteLine("\n----------------------------------------\n");

        e1.PrintShipment();
        Console.WriteLine("\n----------------------------------------\n");

        i1.PrintShipment();
        Console.WriteLine("\n========================================\n");

        Console.WriteLine("Tracking Status\n");
        ITrackable[] trackables = new ITrackable[] { s1, e1, i1 };
        foreach (ITrackable t in trackables)
        {
            Console.WriteLine(t.GetTrackingStatus() + "\n");
        }
        Console.WriteLine("========================================\n");

        Console.WriteLine("Insurance\n");
        IInsurable[] insurables = new IInsurable[] { s1, e1, i1 };

        Console.WriteLine($"Standard Shipment Insurance : {insurables[0].CalculateInsurance()}");
        Console.WriteLine($"Express Shipment Insurance : {insurables[1].CalculateInsurance()}");
        Console.WriteLine($"International Shipment Insurance : {insurables[2].CalculateInsurance()}");

        Console.WriteLine("========================================\n");
        Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
        #endregion
    }
}