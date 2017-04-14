using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PG10Assignment03_AlejandroGamez {

    public class Input {

        public static List<ConsoleKey> keysPressed = new List<ConsoleKey>();

        
        public static void KeyUp() {

            ConsoleKeyInfo cki;

            do {
                Console.WriteLine("\nPress a key to display; press the 'x' key to quit.");

                // Your code could perform some useful task in the following loop. However, 
                // for the sake of this example we'll merely pause for a quarter second.

                while(Console.KeyAvailable == false) {
                    
                    Thread.Sleep(250); // Loop until input is entered.
                }

                cki = Console.ReadKey(true);
                Console.WriteLine("You pressed the '{0}' key.", cki.Key);

                keysPressed
            } while(cki.Key != ConsoleKey.X);
        }

        //Print function for not writing Console.WriteLine everytime. Accepts arguments and color
        public static void Print(string text, ConsoleColor color = ConsoleColor.White, object var1 = null, object var2 = null, object var3 = null, object var4 = null) {
            Console.ForegroundColor = color;
            Console.WriteLine(text, var1, var2, var3, var4);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Overloads to int and float values but uses the same print function converting to string.
        public static void Print(int num) {
            Print(num.ToString());
        }
        public static void Print(float num) {
            Print(num.ToString());
        }

        //Ask for a number. User has to type only numbers.
        public static float ReadFloat(string question) {
            //Ask User for a number
            Print(question);

            //Initialize variable with input
            string input = Console.ReadLine();

            //Create return variable
            float parsedFloat;

            //If input is not a number, try for another input
            while(!float.TryParse(input, out parsedFloat)) {

                //Inquire that the input is invalid and ask again.
                Print("--INVALID INPUT--\nTry Again.\n\n{0}", ConsoleColor.Red, question);
                //Assing read value.
                input = Console.ReadLine();
            }
            //Return numeric input
            return parsedFloat;
        }
        //Get flotant input with limited values
        public static float ReadFloat(string question, float minVal, float maxVal) {
            //Store input in temporary variable to validate
            float tempfloat = ReadFloat(question);

            //If input is not in range, try for anotehr value
            while(tempfloat < minVal || tempfloat > maxVal) {
                //Inquire that the input is invalid and ask again.
                Print("--INVALID INPUT--\nTry Again.\n\n", ConsoleColor.Red);
                Pause();

                tempfloat = ReadFloat(question, minVal, maxVal);
            }

            //Return the input
            return tempfloat;
        }

        //Reusing ReadFloat to read Integer values
        public static int ReadInt(string question) {
            return (int)ReadFloat(question);
        }
        public static int ReadInt(string question, int minVal, int maxVal) {
            return (int)ReadFloat(question, minVal, maxVal);
        }

        //Read a string and asking for input
        public static string ReadString(string question) {
            //Ask User for a string
            Print(question);

            //Return input
            return Console.ReadLine();
        }

        //Pause console for various reasons
        public static void Pause() {
            //Print Message for user input
            Print("\n\t\t\t--PRESS ANY KEY TO CONTINUE--", ConsoleColor.Red);

            //Wait for user to continue.
            Console.ReadKey();
        }
    }
}