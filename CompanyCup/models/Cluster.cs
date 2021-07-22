using System.Linq;
using CompanyCup.enums;

namespace CompanyCup.models
{
    public class Cluster
    {
        public Cluster(ResourceType resourceType, string detailString)
        {
            ResourceType = resourceType;

            var details = detailString.Split(",");

            // 1. Get the Id
            Id = details[0];

            // 2. Get the coordinates
            Coordinates = new Dimension(details.Skip(1).Take(3).ToArray());

            // 3. Get amount of resources
            NumResources = int.Parse(details[4]);
        }

        public string Id { get; set; }
        public ResourceType ResourceType { get; set; }
        public Dimension Coordinates { get; set; }
        public int NumResources { get; set; }
    }
}
