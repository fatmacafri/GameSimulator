using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Abstract
{
    interface ISalesService
    {
        void Sales(Gamer gamer, Game game);
        void CampaignSales(Gamer gamer, Game game, Campaign campaign);
    }
}
