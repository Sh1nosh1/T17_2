using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2__Task_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Staff> staff = new List<Staff>();
                bool flag = true;
                Write("For enter the information about staff member, press E.\nTo close the console press C.");
                while (flag)
                {
                    ConsoleKeyInfo key = ReadKey(true);
                    WriteLine("\n");
                    if (key.Key == ConsoleKey.E) 
                    { 
                        Engineer engineer = new Engineer(); 
                        staff.Add(Engineer.Input()); 
                        Write("\nPress E to continue, Esc to stop, C to close console"); 
                    }
                    else if (key.Key == ConsoleKey.Escape) 
                    { 
                        Clear(); 
                        foreach (var elem in staff) { elem.Output(); WriteLine(); } 
                        flag = false; 
                    }
                    else if (key.Key == ConsoleKey.C) { Environment.Exit(0); }
                    else { Write("You pressed the wrong key. Try again!"); }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
