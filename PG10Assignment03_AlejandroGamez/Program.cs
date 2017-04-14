using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez {
    class Program {
        static void Main(string[] args) {
        //Initialize reset bool
        bool reset = false;

            //Creating a Game variable
            Game game;

            //While loop to reset the game
            do {
                //Clear Screen
                Console.Clear();

                //Initialize a new game class
                game = new Game();

                //Read Input, convert to capital letters and save value
                string input = Input.ReadString("Want to play again?\nYes --- Y\nNo --- N").ToUpper();

                //While loop to ensure correct answer
                while((!input.Contains('N') && !input.Contains('Y')) || input.Length != 1) {
                    //Clear screen
                    Console.Clear();

                    //Read Input, convert to capital letters and save value
                    input = Input.ReadString("--INVALID INPUT--\nTry again.\n\nWant to play again?\nYes --- Y\nNo --- N").ToUpper();
                }

                //Assing value depending on user input.
                reset = input == "Y" ? true : false;
            } while(reset);
            Input.Print("\t\t---THANK YOU FOR PLAYING---\n\t\t ---See you next time!!---\n");
            Input.Pause();

        }
    }
}
