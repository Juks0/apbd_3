  using System.Text;

  public class Ship
    {
        private List<Container> _containers;
        public int MaxSpeed { get; }
        public int MaxNumOfContainers { get; }
        public int MaxWeightAllContainers { get; }

        public Ship(int maxSpeed, int maxNumOfContainers, int maxWeightAllContainers)
        {
            _containers = new List<Container>();
            MaxSpeed = maxSpeed;
            MaxNumOfContainers = maxNumOfContainers;
            MaxWeightAllContainers = maxWeightAllContainers;
        }

        public void LoadContainer(Container container)
        {
            if (_containers.Count >= MaxNumOfContainers)
                throw new InvalidOperationException($"Cannot load more containers than {MaxNumOfContainers}");

            _containers.Add(container);
        }

        public void LoadContainersFromList(List<Container> containers)
        {
            if (_containers.Count + containers.Count > MaxNumOfContainers)
                throw new InvalidOperationException($"Cannot load more containers than {MaxNumOfContainers}");

            var totalWeight = 0;
            foreach (var cont in containers)
                totalWeight += cont.OwnWeight;

            if (totalWeight > MaxWeightAllContainers)
                throw new InvalidOperationException("Total weight exceeds the maximum allowed weight for this ship");

            _containers.AddRange(containers);
        }

        public void DeleteContainer(Container container)
        {
            _containers.Remove(container);
        }

        public void ReplaceContainer(Container container, int numOfContainer)
        {
            var existingContainer = _containers.Find(c => c.NumOfContainer == numOfContainer);
            if (existingContainer != null)
            {
                var index = _containers.IndexOf(existingContainer);
                _containers[index] = container;
            }
            else
            {
                throw new KeyNotFoundException($"Container with number {numOfContainer} not found");
            }
        }

        public void TransferContainerBetweenTwoShips(Container container, Ship ship)
        {
            DeleteContainer(container);
            ship.LoadContainer(container);
        }

        public void InfoAboutShip()
        {
            var info = new StringBuilder();
            info.AppendLine($"Max speed: {MaxSpeed}");
            info.AppendLine($"Max num of containers: {MaxNumOfContainers}");
            info.AppendLine($"Max weight for all containers: {MaxWeightAllContainers}");

            foreach (var container in _containers)
                info.AppendLine(container.ToString());

            Console.WriteLine(info.ToString());
        }
    }