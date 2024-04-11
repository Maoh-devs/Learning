using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Si saca los 3 dados iguales gana
            Game juego = new Game();
            juego.Play();
            Console.ReadLine();
        }

        class Dado
        {
            private int val;
            private static Random rand;

            public Dado()
            {
                rand = new Random();
            }
            public void Launch()
            {
                val = rand.Next(1,6);
            }
            public void Show()
            {
                Console.WriteLine($"Has sacado {val}.");
            }
            public int ReturnVal()
            {
                return val;
            }
        }
        class Game
        {
            public Dado dado1, dado2, dado3;

            public Game()
            {
                dado1 = new Dado();
                dado2 = new Dado();
                dado3 = new Dado();
            }
            public void Play()
            {
                dado1.Launch();
                dado1.Show();
                dado2.Launch();
                dado2.Show();
                dado3.Launch();
                dado3.Show();
                if (dado1.ReturnVal() == dado2.ReturnVal() && dado1.ReturnVal() == dado3.ReturnVal())
                {
                    Console.WriteLine("!!!Ganaste¡¡¡");
                }
                else
                {
                    Console.WriteLine("!!!Perdiste¡¡¡");
                }
            }
        }
    }
}
