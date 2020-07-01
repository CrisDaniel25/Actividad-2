using System;

namespace Actividad_2
{
    public class Program
    {
        public static string Statement = "Select pattern what do you want to use: " +
            "1-(ObserverPattern) ; 2-(SigletonPattern) ; 3-(CommandPattern) ; 0-(Exit to the program):";

        static void Main(string[] args)
        {          
        Restar:
            Console.WriteLine(Statement);
            try
            {
                int index = Convert.ToInt32(Console.ReadLine());

                Menu_Class menu = new Menu_Class();
                menu.Menu_Method(index);
            }
            catch(Exception)
            {
                Console.WriteLine(Statement);
            }
            goto Restar;
        }
    }

    public class Menu_Class
    {
        public void Menu_Method(int Index)
        {
            switch(Index)
                {
                case 1:
                    ObserverPattern_CSharp.ObserverPattern observer = new ObserverPattern_CSharp.ObserverPattern();
                    observer.Main();
                    break;
                case 2:
                    SigletonPattern_CSharp.SigletonPattern sigleton = new SigletonPattern_CSharp.SigletonPattern();
                    sigleton.Main();
                    break;
                case 3:
                    CommandPattern_CSharp.CommandPattern command = new CommandPattern_CSharp.CommandPattern();
                    command.Main();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
