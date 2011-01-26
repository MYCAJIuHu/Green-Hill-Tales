using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONSOLE_The_Game
{
    class Game
    {


        public void GameInit()
        {
            
            Console.SetWindowSize(81, 38);
            Console.SetBufferSize(81, 38);
            Console.Title = "CONSOLE — консольная ММОРПГ";
            Console.CursorVisible = false;
        }

        public void TitleScreen()
        {
            ConsoleKeyInfo k;
            ConsoleFitches CF = new ConsoleFitches();
            Console.Clear();

            CF.GlowingText("░░░░░   ░░░░░   ░   ░   ░░░░░░   ░░░░░   ░      ░░░░░  ", 0, 5, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("░▒▒▒▒▒  ░▒▒▒▒▒  ░▒  ░▒  ░▒▒▒▒▒▒  ░▒▒▒▒▒  ░▒     ░▒▒▒▒▒ ", 0, 6, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("░▒▓▓▓▓▓ ░▒▓▓▓▓▓ ░▒▓ ░▒▓ ░▒▓▓▓▓▓▓ ░▒▓▓▓▓▓ ░▒▓    ░▒▓▓▓▓▓", 0, 7, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("░▒▓     ░▒▓ ░▒▓ ░▒▓▓░▒▓ ░▒▓▒▒▒▒  ░▒▓ ░▒▓ ░▒▓    ░▒▓▒   ", 0, 8, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("░▒▓░░   ░▒▓░░▒▓ ░▒▓ ▓▒▓ ░▒▓▓▓▓▓▓ ░▒▓░░▒▓ ░▒▓░░  ░▒▓▓▓  ", 0, 9, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText(" ▒▓▒▒▒   ▒▓▒▒▒▓  ▒▓  ▓▓  ▒▒▒▒▒ ▓  ▒▓▒▒▒▓  ▒▓▒▒▒  ▒▓▒▒▒ ", 0, 10, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("  ▓▓▓▓▓   ▓▓▓▓▓   ▓   ▓   ▓▓▓▓▓▓   ▓▓▓▓▓   ▓▓▓▓▓  ▓▓▓▓▓", 0, 11, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);


            CF.GlowingText("hardc Oo re :: MYCAJIuHu", 0, Console.WindowHeight / 2 - 5, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 350);
            CF.GlowingText("Представляет...", 0, Console.WindowHeight / 2 - 3, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 350);
            CF.TypeText("CONSOLE — Массовая Многопользовательская Консольная РПГ", 0, Console.WindowHeight / 2, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.TypeText("по сеттингу Forgotten Realms приближенная к правилам D&D 3.5 ", 0, Console.WindowHeight / 2 + 1, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);

            CF.GlowingText("░░░░░   ░░░░░   ░   ░   ░░░░░░   ░░░░░   ░      ░░░░░  ", 0, 5, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("░▒▒▒▒▒  ░▒▒▒▒▒  ░▒  ░▒  ░▒▒▒▒▒▒  ░▒▒▒▒▒  ░▒     ░▒▒▒▒▒ ", 0, 6, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("░▒▓▓▓▓▓ ░▒▓▓▓▓▓ ░▒▓ ░▒▓ ░▒▓▓▓▓▓▓ ░▒▓▓▓▓▓ ░▒▓    ░▒▓▓▓▓▓", 0, 7, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("░▒▓     ░▒▓ ░▒▓ ░▒▓▓░▒▓ ░▒▓▒▒▒▒  ░▒▓ ░▒▓ ░▒▓    ░▒▓▒   ", 0, 8, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("░▒▓░░   ░▒▓░░▒▓ ░▒▓ ▓▒▓ ░▒▓▓▓▓▓▓ ░▒▓░░▒▓ ░▒▓░░  ░▒▓▓▓  ", 0, 9, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText(" ▒▓▒▒▒   ▒▓▒▒▒▓  ▒▓  ▓▓  ▒▒▒▒▒ ▓  ▒▓▒▒▒▓  ▒▓▒▒▒  ▒▓▒▒▒ ", 0, 10, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);
            CF.GlowingText("  ▓▓▓▓▓   ▓▓▓▓▓   ▓   ▓   ▓▓▓▓▓▓   ▓▓▓▓▓   ▓▓▓▓▓  ▓▓▓▓▓", 0, 11, ConsoleColor.Black, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Black, true, false, true, 77);

            do
            {
                CF.GlowingText("Для старта нажмите пробел...", 0, Console.WindowHeight / 2 + 3, ConsoleColor.Black, ConsoleColor.DarkRed, ConsoleColor.Red, ConsoleColor.Black, true, false, true, 350);
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Spacebar);
        }
    }
}
