using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Linlin Han
 * Date: July 13, 2017
 * Description: Demo for Lesson 9
 * Version: 0.7 - Modified Driver class to implement SuperHero
 */

namespace COMP123_S2017_Lab24_SuperVillain
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());


        }
    }
}
