using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " EKLENDİ. --> KAMPANYANIN İNDİRİM ORANI : %" + campaign.DiscountRate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " SİLİNDİ.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " GÜNCELLENDİ. --> KAMPANYANIN İNDİRİM ORANI : %" + campaign.DiscountRate);
        }
    }
}
