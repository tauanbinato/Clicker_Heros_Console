using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez {
    class Game {
        bool isRuning = true;

        public Game() {
            Console.SetWindowSize(150, 50);
            do {

                
                switch(Input.KeyDown()) {
                    case ConsoleKey.Spacebar:
                        Input.Print("space");
                        break;

                    case ConsoleKey.Backspace:
                        Screen.ClearScreen();
                        break;

                    case ConsoleKey.Escape:
                        isRuning = false;
                        break;
                    default:
                        break;
                }
            } while(isRuning);
            
        }
    }
}
