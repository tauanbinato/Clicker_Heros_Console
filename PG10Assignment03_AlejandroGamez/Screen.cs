﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG10Assignment03_AlejandroGamez.Properties;


namespace PG10Assignment03_AlejandroGamez {
    class Screen {

        //;kdsanf;salknf;lksfd
        //;kdsanf;salknf;lksfd
        //;kdsanf;salknf;lksfd
        //;kdsanf;salknf;lksfd
        //;kdsanf;salknf;lksfd
        //;kdsanf;salknf;lksfd
        //;kdsanf;salknf;lksfd

        //clears the screen and draws the HUD again 
        public static void ClearScreen() {
            string textFile = Resources.hud;
            string texFile2 = Resources.Enemy1;
            //Clears the screen
            Console.Clear();
            for(int i = 0; i < texFile2.Length; ++i) {
                int index = textFile.IndexOf('*');
                char c2Change = texFile2.ElementAt(i);
                if() {

                }
                textFile = textFile.Remove(index, 1);
                
                textFile = textFile.Insert(index, .ToString());
            }
            
            
            Input.Print(textFile,ConsoleColor.Red);
        }
    }
}
