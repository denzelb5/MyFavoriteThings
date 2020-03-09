using System;
using MyFavoriteThings.Bikes;
using MyFavoriteThings.WoodWorking;
using MyFavoriteThings.Music;
using MyFavoriteThings.Video;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bicycles, woodworking, music, and video games. These are a few of my favorite things.  How about you?");
            var redBike = new Bike("red");
            redBike.HasPedals = true;
            redBike.BikeColor();
            redBike.Ride();

            var mountainBike = new Bike("blue");
            mountainBike.BikeColor();
            mountainBike.Ride();

            Console.WriteLine("Do you like to woodwork?");
            var woodworker = new Woodwork();
            woodworker.Build();
            woodworker.UsePowerTools();

            var craftsman = new Woodwork();
            woodworker.Build();
            woodworker.UsePowerTools();

            var musician = new playMusic();
            musician.Preference();
            musician.Instrument();

            var gamer = new VideoGames();
            gamer.likesGames();
            gamer.GameSystem();

            var gamester = new VideoGames();
            gamester.likesGames();
            gamester.GameSystem();


        }
    }
}
