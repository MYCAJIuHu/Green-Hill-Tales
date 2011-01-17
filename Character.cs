using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace CONSOLE_The_Game
{
    class Character
    {
        //Данные
        protected string FirstName;
        protected string LastName;
        protected string Nick;
        protected string Deity;

        //Основные характеристики
        protected int STR;
        protected int DEX;
        protected int CON;
        protected int INT;
        protected int WIS;
        protected int CHA;

        //Хит поинты
        protected int HP;

        //Опыт
        protected int XP;

        //Атака, урон, класс защиты
        protected int AttackRate;
        protected int Damage;
        protected int KB;

        /*Снаряжение и инвентарь
         * 0-Левая рука
         * 1-Правая рука
         * 2-Голова 
         * 3-Тело
         * 4-Боты
         * 5-Перчи
         * 6-Амулет
         * 7-Кольцо
         * 8-Кольцо
         * 9-Пояс
         * 10-Накидка
         */
        protected int[] Equipment = new int[11];

        /* 1е значение - Номер закладки
         * 2е значение - Номер строки
         * 3е значение - Номер ячейки в строке
         */
        protected int[,,] Inventory = new int[5, 5, 5];
        
        //Базовые характеристики
        protected int AttackBase;
        protected int FortitudeSavingThrow;
        protected int ReactionSavingThrow;
        protected int WillSavingThrow;
        protected int SpellResistance;

        protected string SpecializationSchool;
        protected string ForbiddenSchool1;
        string ForbiddenSchool2;

        //Друид и ?рейнджер?
        protected string[] AnimalCompanion = { "Badger", "Camel", "fierce rats", "dogs", "sled dogs", "eagle", "hawk", "light horse", "heavy horse", "owl", "pony", "small Viper", "Viper average" };

        //Приживал (компаньон-животное волшебника или колдуна)
        protected string[] Sponger = { "Bat", "Cat", "Hawk", "Lizard", "Owl", "Rat", "Raven", "Snake", "Weasel", "Toad" };
        
        //Владение языками
        protected bool GnomeLanguage;
        protected bool DwarfLanguage;
        protected bool HalfingLanguage;
        protected bool OrcLanguage;
        protected bool ElfLanguage;
        protected bool InfernalLanguage;
        protected bool HeavenlyLanguage;
        protected bool DruidLanguage;
        protected bool DragonLanguage;

        //Расса
        protected string[] Race = { "Human", "Half orc", "Elf", "Half-elf", "Gnome", "Dwarf", "Halfling" };
        

        // Переменные для задания класса
        protected string[] AvaibleClass = { "Bard", "Barbarian", "Warrior", "Magician", "Druid", "Priest", "Sorcerer", "Monk", "Paladin", "Rogue", "Ranger" };
        protected string[] Class = new string[3];

        //Методы для переменной класс.

        //Возвращает отформатированное название класса(с сабклассами и их уровнями)  string
        public string[] CharacterClass
        {
            get
            {
                return Class;
            }

        }

        public string Character1Class
        {
            get
            {
                if (Class[0] == null) return null; else return Class[0].ToString();
            }

            set
            {
                Class[0] = value;
            }
        }

        public string Character2Class
        {
            get
            {
                if (Class[1] == null) return null; else return Class[1].ToString();
            }
            set
            {
                Class[1] = value;
            }
        }

        public string Character3Class
        {
            get
            {
                if (Class[2] == null) return null; else return Class[2].ToString();
            }
            set
            {
                Class[2] = value;
            }
        }

        //Уровень персонажа, Уровень каждого класса

        protected int Chlvl;
        protected int C1lvl;
        protected int C2lvl;
        protected int C3lvl;

        public int CharacterLevel
        {
            get
            {
                Chlvl = C1lvl + C2lvl + C3lvl;
                return Chlvl;
            }
        }

        public int Charachter1ClassLVL
        {
            get
            {
                return C1lvl;
            }
            set
            {
                C1lvl = value;
            }
        }
        public int Charachter2ClassLVL
        {
            get
            {
                return C2lvl;
            }

            set
            {
                C2lvl = value;
            }
        }
        public int Charachter3ClassLVL
        {
            get
            {
                return C3lvl;
            }
            set
            {
                C3lvl = value;
            }
        }


        //Характеристики

        public int Strenght
        {
            get
            {
                return STR;
            }
            set
            {
                STR = value;
            }
        }
        public int Dexterity
        {
            get
            {
                return DEX;
            }
            set
            {
                DEX = value;
            }
        }
        public int Constitution
        {
            get
            {
                return CON;
            }
            set
            {
                CON = value;
            }
        }
        public int Intelligence
        {
            get
            {
                return INT;
            }
            set
            {
                INT = value;
            }
        }
        public int Wisdom
        {
            get
            {
                return WIS;
            }
            set
            {
                WIS = value;
            }
        }
        public int Charisma
        {
            get
            {
                return CHA;
            }
            set
            {
                CHA = value;
            }
        }

        //Модификаторы характеристик
        public int MODStrenght
        {
            get
            {
                int MOD;
                MOD = STR - 10;
                if (MOD == 0) return MOD; else return MOD / 2;
            }
        }

        public int MODDexterity
        {
            get
            {
                int MOD;
                MOD = DEX - 10;
                if (MOD == 0) return MOD; else return MOD / 2; 
            }
        }

        public int MODConstitution
        {
            get
            {
                int MOD;
                MOD = CON - 10;
                if (MOD == 0) return MOD; else return MOD / 2;
            }
        }

        public int MODIntelligence
        {
            get
            {
                int MOD;
                MOD = INT - 10;
                if (MOD == 0) return MOD; else return MOD / 2;
            }
        }

        public int MODWisdom
        {
            get
            {
                int MOD;
                MOD = WIS - 10;
                if (MOD == 0) return MOD; else return MOD / 2;
            }
        }

        public int MODCharisma
        {
            get
            {
                int MOD;
                MOD = CHA - 10;
                if (MOD == 0) return MOD; else return MOD / 2;
            }
        }


        //Базовая атака. Возврщаемое значение зависит от уровня.
        //входное (уровень класса) / выходное (уровень атаки) значение INT
        protected int AttackBaseHight(int ClLVL)
        {
            int ab=0;
            switch (ClLVL)
            {
                case 1: ab = 1; break;
                case 2: ab = 2; break;
                case 3: ab = 3; break;
                case 4: ab = 4; break;
                case 5: ab = 5; break;
                case 6: ab = 6; break;
                case 7: ab = 7; break;
                case 8: ab = 8; break;
                case 9: ab = 9; break;
                case 10: ab = 10; break;
                case 11: ab = 11; break;
                case 12: ab = 12; break;
                case 13: ab = 13; break;
                case 14: ab = 14; break;
                case 15: ab = 15; break;
                case 16: ab = 16; break;
                case 17: ab = 17; break;
                case 18: ab = 18; break;
                case 19: ab = 19; break;
                case 20: ab = 20; break;
            }
            return ab;
        }

        protected int AttackBaseMedium(int ClLVL)
        {
            int ab = 0;
            switch (ClLVL)
            {
                case 1: ab = 0; break;
                case 2: ab = 1; break;
                case 3: ab = 2; break;
                case 4: ab = 3; break;
                case 5: ab = 3; break;
                case 6: ab = 4; break;
                case 7: ab = 5; break;
                case 8: ab = 6; break;
                case 9: ab = 6; break;
                case 10: ab = 7; break;
                case 11: ab = 8; break;
                case 12: ab = 9; break;
                case 13: ab = 9; break;
                case 14: ab = 10; break;
                case 15: ab = 11; break;
                case 16: ab = 12; break;
                case 17: ab = 12; break;
                case 18: ab = 13; break;
                case 19: ab = 14; break;
                case 20: ab = 15; break;
            }
            return ab;
        }

        protected int AttackBaseLow(int ClLVL)
        {
            int ab = 0;
            switch (ClLVL)
            {
                case 1: ab = 0; break;
                case 2: ab = 1; break;
                case 3: ab = 1; break;
                case 4: ab = 2; break;
                case 5: ab = 2; break;
                case 6: ab = 3; break;
                case 7: ab = 3; break;
                case 8: ab = 4; break;
                case 9: ab = 4; break;
                case 10: ab = 5; break;
                case 11: ab = 5; break;
                case 12: ab = 6; break;
                case 13: ab = 6; break;
                case 14: ab = 7; break;
                case 15: ab = 7; break;
                case 16: ab = 8; break;
                case 17: ab = 8; break;
                case 18: ab = 9; break;
                case 19: ab = 9; break;
                case 20: ab = 10; break;
            }
            return ab;
        }

        public int AttacksPerRound(int AtckBase)
        {
            int count;
            count = AtckBase / 5;
            if (count == 0) count = 1;
            return count;
        }
        


    }
}
