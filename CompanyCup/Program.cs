using CompanyCup.models;
using Practice;

namespace CompanyCup
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = FileHelper.Read("1.txt");

            // 1. Create the world
            var worldDetails = lines[0];
            var world = new World(worldDetails);

        }
    }
}
