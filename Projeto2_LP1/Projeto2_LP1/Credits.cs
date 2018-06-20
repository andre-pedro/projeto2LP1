using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Credits
    {
        public void Print()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("╔═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(56, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Credits]");
            Console.ResetColor();
            Console.SetCursorPosition(34, 4);
            Console.WriteLine("- Universidade Lusófona de Humanidades e Tecnologias - ");
            Console.SetCursorPosition(27, 6);
            Console.WriteLine("This project was made by André Pedro," +
                " André Santos and Tiago Alves.");
            Console.SetCursorPosition(48, 8);
            Console.WriteLine("Press any Key to continue...");

            Console.SetCursorPosition(0, 10);
            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                "════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
    }
}
