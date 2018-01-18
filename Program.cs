using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            //Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //Create another List that contains that last two planet of our solar system.
            List<string> planetListLast = new List<string>(){"Neptune", "Uranus"};

            //Combine the two lists by using AddRange().
            planetList.AddRange(planetListLast);
            
            //Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(2, "Earth");
            planetList.Insert(3, "Venus");

            //Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
            var rockies = planetList.GetRange(3,3);
            List<string> rockyPlanets = new List<string>(rockies);

            foreach (string rocky in rockyPlanets)
            {
                Console.WriteLine($"Rockies: {rocky}");
            }

            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }


            //Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.
            Dictionary<string, string> spacecraft = new Dictionary<string, string>();
            spacecraft.Add("Mars", "Viking, Opportunity, Curiosity");
            spacecraft.Add("Venus", "Mariner, Venera");
            spacecraft.Add("Earth", "Mars 1, Mariner 4");
            spacecraft.Add("Neptune", "Voyager 2");

             //Iterate over your list of planets from above, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.
            foreach(var planet in planetList)
            {
                foreach(var keyValue in spacecraft)
                {
                    if(planet == keyValue.Key){
                        Console.WriteLine($"{planet}: {keyValue.Value}" );
                    }
                }
            }            
        }
    }
}
