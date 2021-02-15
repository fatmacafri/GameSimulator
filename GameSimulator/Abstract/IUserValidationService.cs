using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator
{
    interface IUserValidationService
    {
        bool Validation(Gamer gamer);
    }
}
