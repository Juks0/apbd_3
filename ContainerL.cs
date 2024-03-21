public class ContainerL : Container, IHazardNotifier
{
    public ContainerL(int weightOfTheLoad, int maxWeightOfTheLoad, int height, int ownWeight, string containerType)
        : base(weightOfTheLoad, maxWeightOfTheLoad, height, ownWeight, containerType)
    { }

    public override void Load(int payLoad)
    {
        if (payLoad > MaxWeightOfTheLoad * 0.5)
            throw new InvalidOperationException("Dangerous cargo can be filled up to 50% of capacity.");

        payLoad = (int)(payLoad * 0.9);
        base.Load(payLoad);
    }

    public void HazardMessage(Container container)
    {
        Console.WriteLine("Dangerous message for: " + container.SerialNumber);
    }
}