using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        public string? Name { get; set; }
        public Choice Selection;

        // Constructor 
        public Player(string name)
        {
            Name = name;
        }

        public void MakeChoice()
        {
            bool validInput;
            do
            {
                validInput = true;
                Console.WriteLine($"Please make a choice, {Name}: rock, paper or scissors: ");
                switch (Console.ReadLine()?.ToLower())
                {
                    case "rock":
                    case "r":
                        Selection = Choice.Rock;
                        break;
                    case "paper":
                    case "p":
                        Selection = Choice.Paper;
                        break;
                    case "scissor":
                    case "s":
                        Selection = Choice.Scissors;
                        break;
                    default:
                        validInput = false;
                        break;
                }
            } while (!validInput);
            
        }
        
        
    }

}
