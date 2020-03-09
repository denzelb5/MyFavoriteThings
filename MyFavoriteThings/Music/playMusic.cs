using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Music
{
    class playMusic
    {
        private bool playsInstrument { get; set; }
        public string genre;

        public void Preference()
        {
            Console.WriteLine("What kind of music do you like?");
            var answer = Console.ReadLine();
            Console.WriteLine($"{answer} is an excellent choice!");
        }

        public void Instrument()
        {
            Console.WriteLine("Do you play an instrument? y / n");
            var response = Console.ReadLine();
            if (response == "y")
            {
                Console.WriteLine("What instrument do you play?");
                var insResponse = Console.ReadLine();
                Console.WriteLine($"{insResponse} is a wonderful instrument.");
                playsInstrument = true;
            }
            else
            {
                Console.WriteLine("We can sell you an instrument for 19,999.95");
                playsInstrument = false;
            }
        }
    }
}
