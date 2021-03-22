using GameSimulationProject.Business.Concrete;
using GameSimulationProject.Entities;
using System;

namespace GameSimulationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerTest();
            //GameTest();
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer
            {
                GamerId = 1,
                DateYear = new DateTime(2001, 08, 10),
                FirstName = "Şule",
                LastName = "Gebedek",
                IdentityNumber = 12312312312
            };
            gamerManager.Add(gamer);

            GameManager gameManager = new GameManager();
            Game game1 = new Game
            {
                GameId = 1,
                GameName = "PUBG",
                GamePrice = 90
            };
            gameManager.Update(game1);

            CampaignRateManager campaignRateManager = new CampaignRateManager();
            Campaign campaign = new Campaign 
            { 
                CampaignId = 1, 
                CampaignName = "Avantajlı %30 İndirim", 
                DiscountRate = 0.30M 
            };
            campaignRateManager.Add(campaign);

            SalesManager salesManager = new SalesManager();
            //İndirimsiz
            salesManager.Sales(gamer, game1);
            //İndirimli
            salesManager.CampaignSales(game1, gamer, campaign);



        }

        private static void GameTest()
        {
            GameManager gameManager = new GameManager();
            Game game = new Game
            {
                GameId = 1,
                GameName = "PUBG",
                GamePrice = 70
            };
            gameManager.Add(game);

            Game game1 = new Game
            {
                GameId = 1,
                GameName = "PUBG",
                GamePrice = 90
            };
            gameManager.Update(game1);
        }

        private static void GamerTest()
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer
            {
                GamerId = 1,
                DateYear = new DateTime(2001, 08, 10),
                FirstName = "Şule",
                LastName = "Gebedek",
                IdentityNumber = 12312312312
            };
            gamerManager.Add(gamer);

            gamerManager.Delete(gamer);
        }
    }
}
