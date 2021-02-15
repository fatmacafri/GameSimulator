using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.YearOfBirth == 1996 && gamer.FirstName == "FATMA" && gamer.LastName == "CAFRİ" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
