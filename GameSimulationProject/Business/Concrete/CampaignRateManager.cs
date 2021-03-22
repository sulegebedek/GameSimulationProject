using GameSimulationProject.Business.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Business.Concrete
{
    public class CampaignRateManager : ICampaignRateService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "isimli kampanya başarıyla eklendi."); 
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "isimli kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "isimli kampanya başarıyla güncellendi.");
        }
    }
}
