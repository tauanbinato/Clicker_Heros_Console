using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez {
    class Game {


        public Game() {
            bool isGameRunning = true;
            do {
                switch(Input.KeyDown(Console.ReadKey(true).Key)) {
                    case ConsoleKey.Spacebar:
                        Input.Print("space");
                        break;
                    case ConsoleKey.Backspace:
                        
                        break;
                    case ConsoleKey.Escape:
                        isGameRunning = false;
                        break;
                }
            } while(isGameRunning);
        }
    }
}
