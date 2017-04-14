using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG10Assignment03_AlejandroGamez.Properties;


namespace PG10Assignment03_AlejandroGamez {
    class Screen {

        

        //clears the screen and draws the HUD 
        public static void ClearScreen() {
            string textFile = Resources.hud;
            string texFile2 = Resources.Enemy1;
            //Clears the screen
            Console.Clear();
            for(int i = 0; i < texFile2.Length-1; ++i) {
                int index = textFile.IndexOf('*');
                if(index > -1) {
                    textFile = textFile.Remove(index, 1);
                    int index2 = texFile2.IndexOf('|');
                    textFile = textFile.Insert(index, texFile2.ElementAt(index2).ToString());
                }
            }
            
            
            Input.Print(textFile,ConsoleColor.Red);
        }
    }
}
