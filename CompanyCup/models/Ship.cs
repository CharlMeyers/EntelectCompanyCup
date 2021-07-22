using System.Collections.Generic;

namespace CompanyCup.models
{
    public class Ship
    {
        public Ship(int capacity)
        {
            Capacity = capacity;
            Coordinates = new Dimension(new List<string> {"0", "0", "0"});
        }

        public int Capacity { get; set; }

        public Dimension Coordinates { get; set; }
    }
}
