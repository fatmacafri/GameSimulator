using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            return true;
        }
    }
}
