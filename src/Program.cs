using System;
using src.Enities;

namespace JogoRPG 
{
    class program
    {
       static void Main (string [] args)
        {
            Knight arus = new Knight ("Arus", 23, " Knight");
            Wizard wizard = new Wizard ("Jennica", 23, " White Wizard" );

            // Console.Write(hero);
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wizard.Attack(1));     
        }
    }
}