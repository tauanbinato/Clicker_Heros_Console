using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PG10Assignment03_AlejandroGamez {
    /*
     How this class works?
        When Level Class instatiate a Monster class, Level needs to pass the map_lvl to Monster constructor.
     */

    class Monster: IDamageable
    {

        //Array of possible monster names
        string[] m_MonsterNames = {"Rat","Crazy-B","Fat Dog","Frogy","Big Foot","Nassy","Curly","Yomama","Puririn","ShalOt","Sleepy",
                                   "Pikachu","Freak Bob","Gordon","Jack Killer","MarcoPolo","Alf","Altas","Samuray Jack","Stinky Pope",
                                   "Bloody Mary","Beer","Tequila"};


        /*Monster Variables===================================================================*/
        //Timer for BOSS
        private float m_Timer;

        //Monster name
        private string m_sName;

        //Monster status float
        private float m_fLife;
        private float m_fLevel;
        private float m_fMonsterLoot; // Need Hero and Player to get good math

        //Pet status booleans
        private bool  m_bIsAlive;

        //===================================================================*/

        //Monster Constructor
        public Monster(int map_lvl)
        {
            Random rnd = new Random();
            Thread.Sleep(15);
            int rndNameIndex = rnd.Next(0, m_MonsterNames.Length);

            m_sName = m_MonsterNames[rndNameIndex];
            m_fLife = 10;
            m_fLevel = map_lvl;
            m_bIsAlive = true;
         
        }

        // Checkers *********************************************************************************************************************

        public bool isMonsterDied()
        {
            if (m_fLife <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //*******************************************************************************************************************************

        // Getters *********************************************************************************************************************

        public string getMonsterName()
        {
            return m_sName;
        }

        public float getMonsterLife()
        {
            return m_fLife;
        }

        public bool isMonsterAlive()
        {
            return m_bIsAlive;
        }

        //  *****************************************************************************************************************************

        // Take Damage ******************************************************************************************************************

        public void TakeDamage(int amount)
        {

        }

    }
}
