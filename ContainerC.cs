public class ContainerC : Container
{
    public string TypeOfProduct { get; }
    public int Temperature { get; }

    public ContainerC(int weightOfTheLoad, int maxWeightOfTheLoad, int height, int ownWeight, string containerType, string typeOfProduct, int temperature)
        : base(weightOfTheLoad, maxWeightOfTheLoad, height, ownWeight, containerType)
    {
        TypeOfProduct = typeOfProduct;
        Temperature = temperature;
        CheckTemperature();
    }

    public void CheckTemperature()
    {
        var warmlist = new List<string>() { "Bananas", "Chocolate", "Butter", "Eggs" };
        var coldlist = new List<string>() { "Fish", "Cheese", "Sausages" };
        var colderlist = new List<string>() { "Meat", "Ice Cream", "Frozen Pizza" };

        if (Temperature >= 10 && Temperature <= 21 && warmlist.Contains(TypeOfProduct))
        {
            Console.WriteLine("Temperature check passed successfully");
        }
        else if (Temperature >= 0 && Temperature <= 9 && coldlist.Contains(TypeOfProduct))
        {
            Console.WriteLine("Temperature check passed successfully");
        }
        else if (Temperature >= -30 && Temperature <= 0 && colderlist.Contains(TypeOfProduct))
        {
            Console.WriteLine("Temperature check passed successfully");
        }
        else
        {
            throw new ArgumentException("Temperature check failed. Please provide correct temperature for the product.");
        }
    }

    public override string GenerateSerialNumber()
    {
        return $"KON-{ContainerType}-{NumOfContainer}";
    }
}