using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        //declaration
        static int score;
        static int health;

        static void ShowHUD()
        {
            Console.WriteLine("Health = " + health);
        }

        static void TakeDamage()
        {
            health = health - 25;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Methods2");

            //initialization

            score = 0;
            health = 100;

            ShowHUD();
           // TakeDamage(10);
            ShowHUD();
           
            ShowHUD();


            //missed most of it cause this man doesnt like to show more then 1/3 of his screen at a time.. 

            Console.ReadKey();
        }
    }
}
