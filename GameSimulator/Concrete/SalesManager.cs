using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class SalesManager : ISalesService
    {
        public void CampaignSales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + campaign.CampaignName + " İLE " + game.GameName + " OYUNUNU ALDI.");
        }

        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName+ " " + game.GameName + " OYUNUNU ALDI.");
        }
    }
}
