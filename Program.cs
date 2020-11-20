using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        public class Accomplice
        {
            public string name { get; set; }
            public int skillLevel { get; set; }
            public double courageFactor { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"
            Plan Your Heist!
            -----------------
            ");
            
            List<Accomplice> accomplices = new List<Accomplice>() {
                new Accomplice () {
                    name = "", 
                    skillLevel = 0, 
                    courageFactor = 0.0}
            };
           
            Console.Write("Please enter your team member's name . . . ");
            string nameResponse = Console.ReadLine();
        }
    }
}
