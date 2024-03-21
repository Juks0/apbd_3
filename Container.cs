public class Container 
{
    private static int _counter = 1;

    public int WeightOfTheLoad { get; set; }
    public int MaxWeightOfTheLoad { get; }
    public int Height { get; }
    public int OwnWeight { get; }
    public int Depth { get; }
    public string SerialNumber { get; }
    public string ContainerType { get; }
    public int NumOfContainer { get; }

    public Container(int weightOfTheLoad, int maxWeightOfTheLoad, int height, int ownWeight, string containerType)
    {
        WeightOfTheLoad = weightOfTheLoad;
        MaxWeightOfTheLoad = maxWeightOfTheLoad;
        Height = height;
        OwnWeight = ownWeight;
        ContainerType = containerType;
        SerialNumber = GenerateSerialNumber();
        NumOfContainer = _counter++;
    }

    public virtual string GenerateSerialNumber()
    {
        return $"KON-{ContainerType}-{NumOfContainer}";
    }

    public virtual void Load(int payLoad)
    {
        if (payLoad > MaxWeightOfTheLoad)
            throw new OverFillException($"Payload exceeds the maximum weight of {MaxWeightOfTheLoad}");

        WeightOfTheLoad = payLoad;
    }

    public virtual void Unload()
    {
        WeightOfTheLoad = 0;
    }

    public override string ToString()
    {
        return $"Serial Number: {SerialNumber}, Type: {ContainerType}, Own Weight: {OwnWeight}, Load Weight: {WeightOfTheLoad}";
    }

  
}