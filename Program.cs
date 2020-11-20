using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            Plan Your Heist!
            -----------------
            ");
            
            List<Accomplice> accomplices = new List<Accomplice>() {};

            while(true)
            {
                Console.Write("Please enter your team member's name . . . ");
                string NameResponse = Console.ReadLine();
                if(NameResponse == "")break;

                Console.Write("Please enter an integer representing your team member's skill level . . . ");
                int SkillLevelResponse = int.Parse(Console.ReadLine());
                
                Console.Write("Please enter a number, including decimal points if appropriate, representing your team member's courage factor . . . ");
                double CourageFactorResponse = double.Parse(Console.ReadLine());
            
                accomplices.Add(
                    new Accomplice() {
                        Name = NameResponse,
                        SkillLevel = SkillLevelResponse,
                        CourageFactor = CourageFactorResponse
                    }
                );
            }
            
            int TotalCount = accomplices.Count;
            Console.WriteLine(TotalCount);
            
            // foreach(Accomplice teamMember in accomplices){
            //     Console.WriteLine(teamMember.Name);
            //     Console.WriteLine(teamMember.SkillLevel);
            //     Console.WriteLine(teamMember.CourageFactor);
            // }
        }
    }
}