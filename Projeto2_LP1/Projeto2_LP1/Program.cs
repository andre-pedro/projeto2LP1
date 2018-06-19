using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.OutputEncoding = Encoding.UTF8;

            Console.CursorVisible = false;

            MainMenu.Display();
        }
    }
}