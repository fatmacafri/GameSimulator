using GameSimulator.Concrete;
using GameSimulator.Entities;
using System;

namespace GameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            Gamer gamer1 = new Gamer() { Id = 1, IdentityNumber = 12345, FirstName = "FATMA", LastName = "CAFRİ", YearOfBirth = 1996 };
            Gamer gamer2 = new Gamer() { Id = 2, IdentityNumber = 54321, FirstName = "ENGİN", LastName = "DEMİROĞ", YearOfBirth = 1985 };
            Gamer gamer3 = new Gamer() { Id = 3, IdentityNumber = 98765, FirstName = "FURKAN", LastName = "CAFRİ", YearOfBirth = 2006 };
            
            Console.WriteLine("-------------OYUNCULAR------------");
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer3);
            gamerManager.Update(gamer2);
            gamerManager.Delete(gamer2);
            gamerManager1.Add(gamer3);
            Game game1 = new Game() { Id = 1, GameName = "CS-GO", GamePrice = 100 };
            Game game2 = new Game() { Id = 2, GameName = "DOTA-2", GamePrice = 150 };
            Game game3 = new Game() { Id = 3, GameName = "FOOTBALL MANAGER", GamePrice = 250 };

            Console.WriteLine("-------------OYUNLAR------------");
            Console.WriteLine("OYUN ADI : " + game1.GameName + " --> OYUN FİYATI : " + game1.GamePrice);
            Console.WriteLine("OYUN ADI : " + game2.GameName + " --> OYUN FİYATI : " + game2.GamePrice);
            Console.WriteLine("OYUN ADI : " + game3.GameName + " --> OYUN FİYATI : " + game3.GamePrice);

            Campaign campaign1 = new Campaign() { Id = 1, CampaignName = "HOŞGELDİN KAMPANYASI", DiscountRate = 20 };
            Campaign campaign2 = new Campaign() { Id = 2, CampaignName = "SEZON SONU KAMPANYASI", DiscountRate = 50 };
            Campaign campaign3 = new Campaign() { Id = 3, CampaignName = "EVDE KAL KAMPANYASI", DiscountRate = 60 };

            Console.WriteLine("-------------KAMPANYALAR------------");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign3);

            Console.WriteLine("-------------SATIŞLAR------------");
            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer1, game1);
            salesManager.CampaignSales(gamer2, game3, campaign3);



        }
    }
}
