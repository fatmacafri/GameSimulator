using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " İSİMLİ YENİ OYUNCU KAYDEDİLDİ.");
            }
            else
            {
                Console.WriteLine("DOĞRULAMA BAŞARISIZ! " + gamer.FirstName + " " + gamer.LastName + " İSİMLİ OYUNCU KAYDEDİLEMEDİ.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " İSİMLİ OYUNCU SİLİNDİ.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " İSİMLİ OYUNCU GÜNCELLENDİ.");
        }
    }
}
