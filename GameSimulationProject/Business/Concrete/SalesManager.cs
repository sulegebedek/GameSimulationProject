using GameSimulationProject.Business.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Business.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            //İndirim
            decimal discountedSales = game.GamePrice - (game.GamePrice * campaign.DiscountRate);

            Console.WriteLine("Sn. " + gamer.FirstName + " " + gamer.LastName + ", " + game.GameName + " isimli oyunu " + campaign.CampaignName + " kampanyası ile " + discountedSales + " TL ye satın aldınız. İyi günler dileriz.");
        }

        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine("Sn. " + gamer.FirstName + " " + gamer.LastName + ", " + game.GameName + " isimli oyunu " + game.GamePrice + " TL ye satın aldınız. İyi günler dileriz.");
            
        }
    }
}
