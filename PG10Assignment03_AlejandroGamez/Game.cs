using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez {
    class Game {
        bool isRuning = true;
        private Screen screen = new Screen();

        public Game() {
            Console.SetWindowSize(150, 50);
            screen.ClearScreen();
            do {

                
                switch(Input.KeyDown()) {
                    case ConsoleKey.Spacebar:
                        
                        break;

                    case ConsoleKey.Backspace:
                        screen.ClearScreen();
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
