using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez {
    class Game {
        bool isRuning = true;
        private Screen screen = new Screen();
        public static int enemyHealth = 50;
        public static int level = 0;

        public Game() {
            Console.SetWindowSize(150, 50);
            screen.ClearScreen();
            do {

                
                switch(Input.KeyDown()) {
                    case ConsoleKey.Spacebar:
                        enemyHealth -= 5;
                        if(enemyHealth <= 0) {
                            level++;
                            enemyHealth = 50 * level;
                        }
                        screen.ClearScreen();
                        
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
