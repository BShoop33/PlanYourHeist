using System;
using System.Collections.Generic;
using System.Linq;

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
            Console.Write("Please enter the difficulty of the bank:  ");
            int DesiredBankDifficulty = int.Parse(Console.ReadLine());

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
            Console.Write("How many times would you like to run this trial? ");
            int scenarios = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int skill = accomplices.Sum(member => member.SkillLevel);
            //Console.WriteLine($"Team Skill Level:  {skill}");
            int attempt = 0;
            while(attempt < scenarios)
            {
            int BankDifficulty = DesiredBankDifficulty;
            int LuckValue = new Random().Next(-10,10);
            int CombinedLuckandDifficultyValue = BankDifficulty + LuckValue;
            
            Console.WriteLine($"Team's Combined Skill:  {skill}");
            Console.WriteLine($"Total Heist Risk:  {CombinedLuckandDifficultyValue}");
            
            if(skill >= CombinedLuckandDifficultyValue)
            {
                Console.WriteLine("Success! You've robbed the bank!");
            }
            else
            {
                Console.WriteLine("Failure! Enjoy federal prison!");
            }
            Console.WriteLine();
            attempt = attempt + 1;
            }

            // int TotalCount = accomplices.Count;
            // Console.WriteLine(TotalCount);

            // foreach(Accomplice teamMember in accomplices){
            //     Console.WriteLine(teamMember.Name);
            //     Console.WriteLine(teamMember.SkillLevel);
            //     Console.WriteLine(teamMember.CourageFactor);
        }
    }
}