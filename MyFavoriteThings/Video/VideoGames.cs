using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Video
{
    class VideoGames
    {
        private bool IsGamer { get; set; }
        public string platform;
        public string game;

        public void likesGames ()
        {
            Console.WriteLine("Do you like playing video games? y / n?");
            var answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("What is your favorite game of all time?");
                var game = Console.ReadLine();
                Console.WriteLine($"{game} is an awesome game!");
                IsGamer = true;
            }
            else
            {
                Console.WriteLine("Bummer! You are missing out!");
                IsGamer = false;
            }
        }

        public void GameSystem ()
        {
            if (IsGamer == true)
            {
                Console.WriteLine("What kind of gaming system do you use?");
                var platform = Console.ReadLine();
                Console.WriteLine($"{platform} is an excellent gaming system");
            }
            else
            {
                Console.WriteLine("If you change your mind, we can sell you an xbox for 19,999.95");
            }
            
        }
    }
}
