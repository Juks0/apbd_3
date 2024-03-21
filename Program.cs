class Program
{
    static void Main(string[] args)
    {
        var containerL1 = new ContainerL(200, 250, 300, 500, "L");  
        var containerL2 = new ContainerL(200, 250, 300, 350, "L");
        var containerC1 = new ContainerC(300, 500, 240, 430, "C", "Chocolate", 11);
        var containerC2 = new ContainerC(300, 600, 120, 200, "C", "Frozen Pizza", -15);
        var containerG1 = new ContainerG(200, 250, 300, 350, "G");
        var containerG2 = new ContainerG(200, 250, 300, 350, "G");
        

        containerG2.Load(200);

        var ship = new Ship(200, 7, 1500);
        containerG1.Unload();
        var tempContainer = containerC1.WeightOfTheLoad;
        Console.WriteLine(tempContainer);

        containerL1.Load(100);
        var containerL1WeightOfTheLoad = containerL1.WeightOfTheLoad;
        Console.WriteLine(containerL1WeightOfTheLoad);

        var containerList = new List<Container> { containerL1, containerG1, containerC1 };
        ship.LoadContainersFromList(containerList);
        ship.InfoAboutShip();

        Console.WriteLine(containerL1);
        Console.WriteLine(containerL2);
        Console.WriteLine(containerG1);
        Console.WriteLine(containerG2);
        Console.WriteLine(containerC1);
        Console.WriteLine(containerC2);
    }
}