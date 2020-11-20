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
            
            Console.Write("Please enter your team member's name . . . ");
            string nameResponse = Console.ReadLine();
            
            Console.Write("Please enter an integer representing your team member's skill level . . . ");
            int skillLevelResponse = int.Parse(Console.ReadLine());
            
            List<Accomplice> accomplices = new List<Accomplice>() {
                new Accomplice () {
                    name = nameResponse, 
                    skillLevel = skillLevelResponse, 
                    courageFactor = 0.0}
            };
            
        }
    }
}
