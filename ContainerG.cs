
public class ContainerG : Container, IHazardNotifier
{
    public ContainerG(int weightOfTheLoad, int maxWeightOfTheLoad, int height, int ownWeight, string containerType)
        : base(weightOfTheLoad, maxWeightOfTheLoad, height, ownWeight, containerType)
    {
    }

    public override void Unload()
    {
        WeightOfTheLoad = (int)(MaxWeightOfTheLoad * 0.05);
    }
    
    public void HazardMessage(Container container)
    {
        Console.WriteLine("Danger message for: " + container.SerialNumber);
    }
}