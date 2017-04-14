using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG10Assignment03_AlejandroGamez.Properties;


namespace PG10Assignment03_AlejandroGamez {
    class Screen {
        private string textFile = Resources.hud;
        //clears the screen and draws the HUD
        public void ClearScreen() {
            //Clears the screen
            Console.Clear();
            textFile = ReplaceCharsWithTextFile('*',Resources.Enemy1, textFile);
            
            Input.Print(textFile, ConsoleColor.Green);
        }

        private string ReplaceCharsWithTextFile(char toReplace, string textFile, string text2Change) {
            string tempString = text2Change;

            textFile = textFile.Replace("\n", "");
            textFile = textFile.Replace("\r", "");

            for(int i = 0; i < textFile.Length; ++i) {
                int index = tempString.IndexOf(toReplace);

                if(index > -1) {

                    tempString = tempString.Remove(index, 1);

                    tempString = tempString.Insert(index, textFile.ElementAt(i).ToString());
                }
            }

            return tempString;
        }
    }
}
