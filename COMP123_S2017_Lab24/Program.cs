using System;

/*
 * Name: Linlin Han
 * Date: July 13, 2017
 * Description: Demo for Lesson 9
 * Version: 0.8 - Modified Driver class to implement SuperVillain
 */

namespace COMP123_S2017_Lab24
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());

            Console.WriteLine("**********Add Super Villains*************");
            SuperVillain superVillain = new SuperVillain("Maleficent", 30);
            superVillain.AddPower("Casting Spell", 30);
            superVillain.AddPower("Flying", 40);
            Console.WriteLine(superVillain.ToString());
        }
    }
}
