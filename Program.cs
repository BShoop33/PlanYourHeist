using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program header
            Console.WriteLine(@"
            Plan Your Heist!
            -----------------
            ");
                
                //Initializing variables for # of trial runs, number of successful trials, and  number of failure trials
                int trial = 0;
                int success = 0;
                int failure = 0;
                int DesiredBankDifficulty = 0;
                int SkillLevelResponse = 0;

                while(true) {
                    try {
                        //Prompts the user to set the  bank difficulty
                        Console.Write("Please enter the difficulty of the bank:  ");
                        DesiredBankDifficulty = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch {
                        Console.WriteLine("You entered an incorrect value. Please enter a whole number for the bank difficulty.\n");
                    }
                }

                //Creates a new empty list named accomplices and consisting of Accomplice objects
                List<Accomplice> accomplices = new List<Accomplice>() {};
                
                    /* Loops through the user prompts for the user to add multiple team members' names, skill levels, 
                    and courage factors. Ends the loop when the user enters a blank response for a team member's name. */
                    while(true) {
                        //Prompts the user to add team members' names
                        Console.Write("Please enter your team member's name . . . ");
                        string NameResponse = Console.ReadLine();
                        if(NameResponse == "")
                        break;
                        
                        while(true) {
                            try {
                                //Prompts the user to add team members' skill levels
                                Console.Write("Please enter an integer representing your team member's skill level . . . ");
                                SkillLevelResponse = int.Parse(Console.ReadLine());
                                if(SkillLevelResponse % 1 == 0){
                                    break;
                                }
                            }
                            catch {
                                Console.WriteLine("You entered an incorrect value. Please enter a whole number for the bank difficulty.\n");
                            }
                        }

                        //Prompts the user to add team members' courage factors
                        Console.Write("Please enter a number, including decimal points if appropriate, representing your team member's courage factor . . . ");
                        double CourageFactorResponse = double.Parse(Console.ReadLine());
                        while (CourageFactorResponse < .01 || CourageFactorResponse > 2.0) {
                            Console.Write("This value may only be between 0.0 and 2.0. Please enter a number within that range . . . ");
                            double CourageHandling = double.Parse(Console.ReadLine());
                            if(CourageHandling >= 0.0 && CourageHandling <= 2.0) {
                                break;
                            }
                        }
                        
                        /*Compiles the team member propmt responses into an Accomplice object and adds that object as a new list item 
                        in the accomplices list*/
                        accomplices.Add(
                            new Accomplice() {
                                Name = NameResponse,
                                SkillLevel = SkillLevelResponse,
                                CourageFactor = CourageFactorResponse
                            }
                        );
                    }

                //Prompts the user to enter the number of times the program should calculate the chances of succeeding in the heist. 
                Console.Write("How many times would you like to run this trial? ");
                int scenarios = int.Parse(Console.ReadLine());
                Console.WriteLine();

                /* Loops through the heist scenarios evaluating whether the team's total skill value is higher than the combined 
                bank difficulty and luck factor value. Ends the loop when the number of calculated heist scenarios matches the 
                number of trials the user prescribed*/
                while(trial < scenarios) {
                    //Initializes the luck value to a randomly generated integer value between  -10 and 10
                    int LuckValue = new Random().Next(-10,10);
                    
                    /*Inializes the LuckyBankDifficultyValue to the value generated by adding the user prescribed bank difficulty 
                    value with the LuckValue*/
                    int LuckyBankDifficultyValue = DesiredBankDifficulty + LuckValue;
                    
                    //Initializes the skill variable to be the sum of all the team members' SkillLevel values
                    int skill = accomplices.Sum(member => member.SkillLevel);

                    //Displays the team members' combined SkillLevel values and the total heist risk 
                    Console.WriteLine($"Team's Combined Skill:  {skill}");
                    Console.WriteLine($"Total Heist Risk:  {LuckyBankDifficultyValue}");
                    
                    /*Calculates a single heist scenario. If the combined value of the team members' SkillLevel are greater than the 
                    combined bank difficulty and luck values then the heist returns as a success. If the combined value of the team 
                    members' SkillLevel are less than the combined bank difficulty and luck values then the heist returns as a failure.*/
                    if(skill >= LuckyBankDifficultyValue) {
                        Console.WriteLine("Success! You've robbed the bank!");
                        success = success + 1;
                    }
                    else {
                        Console.WriteLine("Failure! Enjoy federal prison!");
                        failure = failure + 1;
                    }
                    Console.WriteLine();
                    trial = trial + 1;
                }

                /*Displays the total number of heist scenarios calculated as being successful as well as the total number calculated as 
                being failures*/
                Console.WriteLine($"Total Successfull Heists:  {success}");
                Console.WriteLine($"Total Failed Heists:  {failure}");
        }
    }
}