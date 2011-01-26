using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONSOLE_The_Game
{
    class ConsoleFitches
    {
        /***************************************
         *Author: Evgeniy V Nikiforov          *
         *ICQ:    736452                       *
         *E-mail: Evgeniy.V.Nikiforov@gmail.com*
         ***************************************
         *Writec Method                        *
         ***************************************
         *Method makes it easy to write to the *
         *console at the specified location    *
         *with specified color, and press the  *
         *text to the left or right.           *
         *                                     *
         *Desirable to specify CursorPosX      *
         *different from 0, when the           *
         *Align == True.                       *
         *                                     *
         *If Align == true, then the text will *
         *apply the alignment or to the left   *
         *or right, depending on the variable  * 
         *FalseLeftTrueRight, the name is      *
         *clearly a value to any result        *
         *would lead.                          *        
         *                                     *
         *Centr parameter is of type bool.     *
         *If Align == true, and Centr == true, *
         *then the parameter FalseLeftTrueRight*
         *ignored and the text will be aligned *
         *in the center.                       *
         * *************************************
         */
        public void Writec(string value, int CursorPosX, int CursorPosY, ConsoleColor ForeColor, ConsoleColor BgColor, bool Align, bool FalseLeftTrueRight, bool Center)
        {
            Console.BackgroundColor = BgColor;
            Console.ForegroundColor = ForeColor;
            Console.SetCursorPosition(CursorPosX, CursorPosY);
            if (Align)
            {
                if (Center)
                {
                    CursorPosX = (Console.WindowWidth / 2) - (value.Length / 2);
                    Console.SetCursorPosition(CursorPosX, CursorPosY);
                    Console.Write(value);
                    Console.ResetColor();
                    return;
                }
                if (!FalseLeftTrueRight)
                {
                    Console.Write(value.PadRight(Console.WindowWidth - 1));
                    Console.ResetColor();
                    return;
                }
                else
                {
                    Console.Write(value.PadLeft(Console.WindowWidth - 1));
                    Console.ResetColor();
                    return;
                }
            }
            Console.Write(value);
            Console.ResetColor();

        }


        /***************************************
        *Author: Evgeniy V Nikiforov           *
        *ICQ:    736452                        *
        *E-mail: Evgeniy.V.Nikiforov@gmail.com *
        ****************************************
        *TypeText Method                       *
        ****************************************
        *This method creates the effect of     *
        *typing.                               *
        *All parameters are similar to the     *
        *method Writec, except for Delay, this *
        *parameter is of type int, sets the    *
        *delay between the print characters    *
        *in milliseconds.                      *
        **************************************** 
        */
        public void TypeText(string value, int CursorPosX, int CursorPosY, ConsoleColor ForeColor, ConsoleColor BgColor, bool Align, bool FalseLeftTrueRight, bool Center, int Delay)
        {
            Console.BackgroundColor = BgColor;
            Console.ForegroundColor = ForeColor;
            string text = "";
            if (Align)
            {
                if (Center)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        text += value[i];
                        CursorPosX = (Console.WindowWidth / 2) - (text.Length / 2);
                        Console.SetCursorPosition(CursorPosX, CursorPosY);
                        Console.Write(text.PadRight(Console.WindowWidth));
                        System.Threading.Thread.Sleep(Delay);
                    }
                    Console.ResetColor();
                    return;
                }

                if (!FalseLeftTrueRight)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        Console.SetCursorPosition(CursorPosX, CursorPosY);
                        text += value[i];
                        Console.Write(text.PadRight(Console.WindowWidth));
                        System.Threading.Thread.Sleep(Delay);
                    }
                    Console.ResetColor();
                    return;
                }
                else
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        Console.SetCursorPosition(CursorPosX, CursorPosY);
                        text += value[i];
                        Console.Write(text.PadLeft(Console.WindowWidth));
                        System.Threading.Thread.Sleep(Delay);
                    }
                    Console.ResetColor();
                    return;
                }
            }

            for (int i = 0; i < value.Length; i++)
            {
                Console.SetCursorPosition(CursorPosX, CursorPosY);
                text += value[i];
                Console.Write(text);
                System.Threading.Thread.Sleep(Delay);
            }
            Console.ResetColor();

        }


        public void GlowingText(string value, int CursorPosX, int CursorPosY, ConsoleColor ForeColor1, ConsoleColor ForeColor2, ConsoleColor ForeColor3, ConsoleColor BgColor, bool Align, bool FalseLeftTrueRight, bool Center, int Delay)
        {
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0: Writec(value, CursorPosX, CursorPosY, ForeColor1, BgColor, Align, FalseLeftTrueRight, Center);
                        break;
                    case 1: Writec(value, CursorPosX, CursorPosY, ForeColor2, BgColor, Align, FalseLeftTrueRight, Center);
                        break;
                    case 2: Writec(value, CursorPosX, CursorPosY, ForeColor3, BgColor, Align, FalseLeftTrueRight, Center);
                        break;
                    case 3: Writec(value, CursorPosX, CursorPosY, ForeColor2, BgColor, Align, FalseLeftTrueRight, Center);
                        break;
                    case 4: Writec(value, CursorPosX, CursorPosY, ForeColor3, BgColor, Align, FalseLeftTrueRight, Center);
                        break;
                }
                System.Threading.Thread.Sleep(Delay);
            }

        }

    }
}
