using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONSOLE_The_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Character C = new Character();

            Console.WriteLine("задаем классы, не добавляя уровень. \nВыводим:");
            C.Character1Class = "Warrior";
            Console.WriteLine(C.CharacterClass[0]);
            C.Character2Class = "Monk";
            Console.WriteLine(C.CharacterClass[1]);
            C.Character3Class = "Cleric";
            Console.WriteLine(C.CharacterClass[2]);
            Console.ReadKey();
            Console.WriteLine("задаем уровни, выводим.");
            C.Charachter1ClassLVL = 1;
            C.Charachter2ClassLVL = 8;
            C.Charachter3ClassLVL = 11;
            Console.WriteLine(C.Character1Class+"("+C.Charachter1ClassLVL+")/"+C.Character2Class+"("+C.Charachter2ClassLVL+")/"+C.Character3Class+"("+C.Charachter3ClassLVL+")");
            Console.ReadKey();
            Console.WriteLine("общий уровень персонажа:"+C.CharacterLevel.ToString());
            Console.ReadKey();
            Console.WriteLine("Выводим модификаторы характеристик");
            Console.WriteLine("modSTR = "+C.MODStrenght.ToString());
            Console.WriteLine("modDEX = " + C.MODDexterity.ToString());
            Console.WriteLine("modCON = " + C.MODConstitution.ToString());
            Console.WriteLine("modINT = " + C.MODIntelligence.ToString());
            Console.WriteLine("modWIS = " + C.MODWisdom.ToString());
            Console.WriteLine("modCHA = " + C.MODCharisma.ToString());
            Console.ReadKey();
            Console.WriteLine("Увеличим характеристики и выведим модификаторы на экран.");
            C.Strenght = 18;
            C.Constitution = 14;
            C.Dexterity = 13;
            C.Intelligence = 13;
            C.Wisdom = 8;
            C.Charisma = 8;
            Console.ReadKey();
            Console.WriteLine("Выводим модификаторы характеристик");
            Console.WriteLine("modSTR = " + C.MODStrenght.ToString());
            Console.WriteLine("modDEX = " + C.MODDexterity.ToString());
            Console.WriteLine("modCON = " + C.MODConstitution.ToString());
            Console.WriteLine("modINT = " + C.MODIntelligence.ToString());
            Console.WriteLine("modWIS = " + C.MODWisdom.ToString());
            Console.WriteLine("modCHA = " + C.MODCharisma.ToString());
            Console.ReadKey();
            Console.WriteLine("Сейчас проверим функцию вывода количества атак в раунде.");
            Console.ReadKey();
            Console.WriteLine(C.AttacksPerRound(1).ToString());
            Console.WriteLine(C.AttacksPerRound(5).ToString());
            Console.WriteLine(C.AttacksPerRound(7).ToString());
            Console.WriteLine(C.AttacksPerRound(19).ToString());
            Console.WriteLine(C.AttacksPerRound(10).ToString());
            Console.WriteLine(C.AttacksPerRound(17).ToString());
            Console.WriteLine(C.AttacksPerRound(20).ToString());
            Console.ReadKey();
            DnDMechanics Dnd = new DnDMechanics();
            Console.WriteLine("Бросим несколько раз кубик d4");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Convert.ToString(Dnd.d4()));
            }
            Console.ReadKey();
            Console.WriteLine("Попробуем перегрузку функции d4 и кинем кубик 4d4");
            Console.WriteLine(Dnd.d4(4).ToString());
            Console.ReadKey();
            Console.WriteLine("Пробуем остальные кубики");
            Console.WriteLine(Dnd.d6().ToString());
            Console.WriteLine(Dnd.d8().ToString());
            Console.WriteLine(Dnd.d10().ToString());
            Console.WriteLine(Dnd.d12().ToString());
            Console.WriteLine(Dnd.d20().ToString());
            Console.ReadKey();

           
        }
    }
}
