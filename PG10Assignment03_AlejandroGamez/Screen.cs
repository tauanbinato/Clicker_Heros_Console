using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG10Assignment03_AlejandroGamez.Properties;


namespace PG10Assignment03_AlejandroGamez {
    class Screen {

        string textFile = Resources.hud;

        //clears the screen and draws the HUD again
        public static void ClearScreen() {
            //Clears the screen
            Console.Clear();

           
        }
    }
}
