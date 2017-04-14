using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PG10Assignment03_AlejandroGamez {
    class Level
    {   

        //Monster in Lvl
        private Monster m_ActiveMonster;
        private int     m_MonstersKilled = 0;
        private int     m_iMaxMonstersPerLvl = 10;

        //Strings
        private string[] m_sMapNames = {"Tutorial","Tundra","Desert","Mom's City","Jungle","Beach","Dark Desert","Ocean","Heaven","Hell"};
        private string   m_sMapName  =  "";

        //Integers
        private int m_iActualLevelLvl = 0;
        
        //Booleans
        private bool m_bIsLevelEnded;

        //Level Constructor ************************************************************************************************************
        public Level()
        {
            m_ActiveMonster     = new Monster(m_iActualLevelLvl);
            m_bIsLevelEnded     = false;
            m_iActualLevelLvl   = 0;
            m_sMapName          = m_sMapNames[m_iActualLevelLvl];
            
        }
        //******************************************************************************************************************************

        public void killMonsterInLvl()
        {
            if(m_MonstersKilled < m_iMaxMonstersPerLvl)
            {   
                m_ActiveMonster = null;
                m_MonstersKilled++;
                m_ActiveMonster = new Monster(m_iActualLevelLvl);
            }
             else
            {
                m_iActualLevelLvl++;
                m_MonstersKilled = 0;
                m_bIsLevelEnded = true;
            }
            


        }
        


        // Checkers *********************************************************************************************************************

        public bool isLevelEnded()
        {
            if (m_bIsLevelEnded)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //*******************************************************************************************************************************

        // Getters **********************************************************************************************************************

        public int getActualLvl()
        {
            return m_iActualLevelLvl;
        }

        public string getActualMap_Name()
        {
            return m_sMapName;
        }

        public Monster getActive_Monster()
        {
            return m_ActiveMonster;
        }

        public int getNumbersOfMonsterKilled()
        {
            return m_MonstersKilled;
        }

        //  *****************************************************************************************************************************


        // Setters **********************************************************************************************************************

        public void goNextLevel()
        {
            // Here we can create an dificulty constant using Hero and Player Class
            // To set a lvl we need some simple math like:
            // Difficult_Constant = totalOfherosActive + playerdamage + TotalDPS / Magic number.
            // We can use that constant to create a new lvl with new monsters dificulties each time the player pass an lvl.

            if (m_bIsLevelEnded)
            {
                m_iActualLevelLvl++;
                m_sMapName = m_sMapNames[m_iActualLevelLvl];
                Monster new_Monster = new Monster(m_iActualLevelLvl);
                m_ActiveMonster = new_Monster;
            }
            else
            {
                Console.WriteLine("Need to kill all monsters first.");
            }
        }

        //  *****************************************************************************************************************************
    }
}
