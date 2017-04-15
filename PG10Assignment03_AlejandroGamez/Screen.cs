using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG10Assignment03_AlejandroGamez.Properties;


namespace PG10Assignment03_AlejandroGamez {
    class Screen {
        private string HUD = Resources.hud;

        private string hero = Resources.Hero;

        private string Enemy = Resources.Enemy;

        //clears the screen and draws the HUD
        public void ClearScreen() {
            //Clears the screen
            Console.Clear();

            HUD = Resources.hud;
            hero = Resources.Hero;

            Enemy = Resources.Enemy;

            for(int i = 0; i < 10; ++i) {
                HUD = ReplaceCharsWithTextFile('+', HUD, hero);
            }
            Enemy = ReplaceCharsWithTextFile('*', Enemy, "Bloody Marry", true);
            Enemy = ReplaceCharsWithTextFile('^', Enemy, Game.level.ToString(), true);
            Enemy = ReplaceCharsWithTextFile('@', Enemy, Game.enemyHealth.ToString(), true);
            Enemy = ReplaceCharsWithTextFile('+', Enemy, Resources.Wolf, true);

            

            HUD = ReplaceCharsWithTextFile('*', HUD, Enemy, true);
            
            Input.Print(HUD, ConsoleColor.Green);
        }

        private string ReplaceCharsWithTextFile(char toReplace, string text2Change, string textFile, bool removeExedent = false) {
            string tempString = text2Change;

            textFile = textFile.Replace("\n", "");
            textFile = textFile.Replace("\r", "");

            for(int i = 0; i < textFile.Length; ++i) {
                int index = tempString.IndexOf(toReplace);

                if(index > -1) {

                    tempString = tempString.Remove(index, 1);

                    tempString = tempString.Insert(index, textFile.ElementAt(i).ToString().ToUpper());
                }
            }

            if(tempString.Contains(toReplace) && removeExedent) {
                tempString = tempString.Replace(toReplace.ToString(), " ");
            }

            return tempString;
        }
    }
}
