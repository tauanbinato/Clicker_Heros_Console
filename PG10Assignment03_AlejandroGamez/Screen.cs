using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG10Assignment03_AlejandroGamez.Properties;


namespace PG10Assignment03_AlejandroGamez {
    class Screen {
        //HUD template
        private string HUD = Resources.hud;
        //Hero template
        private string hero = Resources.Hero;
        //Enemy Template
        private string enemy = Resources.Enemy;

        //clears the screen and draws the HUD
        public void ClearScreen() {
            //Clears the screen
            Console.Clear();
            
            //Reset the variables for repainting
            HUD = Resources.hud;
            hero = Resources.Hero;
            enemy = Resources.Enemy;

            //Replace the + characters for whatever is inside the hero file
            for(int i = 0; i < 10; ++i) {
                //Set the HUD file as file with the hero HUD istead of + characters.
                HUD = ReplaceCharsWithTextFile('+', HUD, hero);
            }

            //Replace specific characters in the enemy file with variables to get updated feedback.
            enemy = ReplaceCharsWithTextFile('*', enemy, Game.monsName, true);
            enemy = ReplaceCharsWithTextFile('^', enemy, Game.level.ToString(), true);
            enemy = ReplaceCharsWithTextFile('@', enemy, Game.enemyHealth.ToString(), true);
            //Replace the + Characters with an Ascii drawing
            enemy = ReplaceCharsWithTextFile('+', enemy, Resources.Wolf, true);

            //Replace all the Enemy template with values inside HUD
            HUD = ReplaceCharsWithTextFile('*', HUD, enemy, true);
            
            //Print the screen
            Input.Print(HUD, ConsoleColor.Green);
        }

        //Replaces characters inside a string with the character inside a textfile or another string, eliminating new line symbols.
        private string ReplaceCharsWithTextFile(char toReplace, string text2Change, string textFile, bool removeExedent = false) {
            //temporary string to save changes
            string tempString = text2Change;

            //Eliminating newLine symbols from the textfile to put.
            textFile = textFile.Replace("\n", "");
            textFile = textFile.Replace("\r", "");

            //Loop through the text file we want to change.
            for(int i = 0; i < textFile.Length; ++i) {
                //Index of the first incidence of the character we want to replace. We always look for the first one because
                //the previous first whould have been deleted and replaced.
                //This metod replaces all the characters 1 by 1.
                int index = tempString.IndexOf(toReplace);

                //Security lock if there are more characters in the text file than in the file we want to change.
                if(index > -1) {
                    //Remove the character in the index of the first incidence of the character we want to replace.
                    tempString = tempString.Remove(index, 1);
                    //insert the index position of the file we want to insert exactky in the index we removed the previous character.
                    tempString = tempString.Insert(index, textFile.ElementAt(i).ToString().ToUpper());
                }
            }

            //if there are remaining characters of what we want to replace but there weren't enough characters in our
            //text file and if we set the remove exedent value to true, replace all remaining charactars with blank spaces.
            if(tempString.Contains(toReplace) && removeExedent) {
                tempString = tempString.Replace(toReplace.ToString(), " ");
            }

            //return the modifyed string
            return tempString;
        }
    }
}
