namespace CompanyCup.models
{
    public class World
    {
        public World(string detailString)
        {
            Dimensions = new Dimension(detailString.Split(","));

            var environmentString = detailString.Split("|");

            // 2. Get number of unique resources
            NumUniqueResources = int.Parse(environmentString[1]);

            // 3. Get number of ships
            NumShips = int.Parse(environmentString[2]);

            // 4. Get ship capacity
            ShipCapacity = int.Parse(environmentString[3]);

            // 5. Get number of labs
            NumLabs = int.Parse(environmentString[4]);

            // 6. Get outpost processed material threshold
            OutputProcessedMaterialThreshold = int.Parse(environmentString[5]);

            // 7. Get number of quotas
            NumQuotas = int.Parse(environmentString[6]);
        }

        public Dimension Dimensions { get; set; }

        public int NumUniqueResources { get; set; }

        public int NumShips { get; set; }

        public int ShipCapacity { get; set; }

        public int NumLabs { get; set; }

        public int OutputProcessedMaterialThreshold { get; set; }

        public int NumQuotas { get; set; }
    }
}
