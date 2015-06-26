using System;

namespace GalacticGPS
{
    class GalacticGPSMain
    {
        static void Main()
        {
            Planet earth = Planet.Earth;

            var home = new Location(18.037986, 28.870097, earth);

            Console.WriteLine(home);
        }
    }
}
