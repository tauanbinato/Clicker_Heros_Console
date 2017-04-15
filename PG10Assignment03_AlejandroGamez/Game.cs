using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez {
    class Game {
        bool isRuning = true;
        private Screen screen = new Screen();
        //test variables -----------------------------------------------------------------------------------------------------------------------------------
        public static int enemyHealth = 50;
        public static int level = 0;
        public static string monsName = "Bloody Mary";
        Random rnd = new Random();
        public string[] m_MonsterNames = {"Rat","Crazy-B","Fat Dog","Frogy","Big Foot","Nassy","Curly","Yomama","Puririn","ShalOt","Sleepy",
                                   "Pikachu","Freak Bob","Gordon","Jack Killer","MarcoPolo","Alf","Altas","Samuray Jack","Stinky Pope",
                                   "Bloody Mary","Beer","Tequila"};
        //test variables -----------------------------------------------------------------------------------------------------------------------------------

        //Player variable not initialized.
        private Player player;


        public Game() {
            //setting the screen size.
            Console.SetWindowSize(150, 50);
            
            //Initializing the player via Singleton.
            player = Player.Instance;

            //Setting the HUD for the first time.
            screen.ClearScreen();

            do {
                switch(Input.KeyDown()) {
                    case ConsoleKey.Spacebar:
                        //All this should be a function inside the monster ---------------------
                        enemyHealth -= 5;
                        if(enemyHealth <= 0) {
                            monsName = m_MonsterNames[rnd.Next(0, m_MonsterNames.Length)];
                            level++;
                            enemyHealth = 50 * level;
                        }
                        //----------------------------------------------------------------------
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
