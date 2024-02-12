using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2_Task_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Bus> bus = new List<Bus>();
                bool flag = true;
                Write("For enter the information about the trip, press Enter.\nTo close the console press Escape.");
                while (flag)
                {
                    ConsoleKeyInfo key = ReadKey(true);
                    WriteLine("\n");
                    if (key.Key == ConsoleKey.Enter) 
                    { 
                        TouristBus tourist_bus = new TouristBus(); 
                        bus.Add(TouristBus.Input()); 
                        Write("\nPress Enter to continue, Backspace to stop and output information, Esc to close console"); 
                    }
                    else if (key.Key == ConsoleKey.Backspace) 
                    { 
                        Clear(); 
                        foreach (var elem in bus) { elem.Output(); WriteLine(); } 
                        flag = false; 
                    }
                    else if (key.Key == ConsoleKey.Escape) { Environment.Exit(0); }
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
