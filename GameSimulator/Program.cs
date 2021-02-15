using GameSimulator.Concrete;
using System;

namespace GameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            { 
                Id = 1, 
                YearOfBirth = 1995, 
                FirstName = "FATMA", 
                LastName = "CAFRİ", 
                IdentityNumber = 12345 
            });
            Console.WriteLine("Hello World!");
        }
    }
}
