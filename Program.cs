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
                string nameResponse = Console.ReadLine();
                // if(nameResponse == "")break;

                Console.Write("Please enter an integer representing your team member's skill level . . . ");
                int skillLevelResponse = int.Parse(Console.ReadLine());
                
                Console.Write("Please enter a number, including decimal points if appropriate, representing your team member's courage factor . . . ");
                double courageFactorResponse = double.Parse(Console.ReadLine());
            
                accomplices.Add(
                    new Accomplice() {
                        Name = nameResponse,
                        SkillLevel = skillLevelResponse,
                        CourageFactor = courageFactorResponse
                    }
                );
            }
            
            // foreach(Accomplice teamMember in accomplices){
            //     Console.WriteLine(teamMember.Name);
            //     Console.WriteLine(teamMember.SkillLevel);
            //     Console.WriteLine(teamMember.CourageFactor);
            // }
        }
    }
}