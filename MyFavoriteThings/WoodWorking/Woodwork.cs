using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.WoodWorking
{
    class Woodwork
    {
        private bool UsesPowerTools { get; set; }
        private bool LikesWood { get; set; }

        public void Build () 
        {
            
            Console.WriteLine("I love to build things with wood. How about you? y / n");
            var response = Console.ReadLine();
            if (response == "y")
            {
                Console.WriteLine("Build on!");
                LikesWood = true;
            } else
            {
                Console.WriteLine("Bummer!  Nobody's perfect! :)");
                LikesWood = false;
            }

            if (LikesWood == true)
            {
                Console.WriteLine("Cool Beans!  Name something you have built.");
                var buildAnswer = Console.ReadLine();
                Console.WriteLine($"Nice Work! I bet it is a really cool {buildAnswer}");
            }
        }

        public void UsePowerTools ()
        {
            if (LikesWood = true)
            {
                Console.WriteLine("Do you use power tools to build? y / n");
                var toolAnswer = Console.ReadLine();

                if (toolAnswer == "y")
                {
                    Console.WriteLine("Build on!");
                }
                else
                {
                    Console.WriteLine("We can sell you a table saw for 19,9999.95!");
                }
            }

        }
    }
}
