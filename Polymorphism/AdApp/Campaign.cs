using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> campaign;

        public Campaign() 
        {
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            campaign.Add(a);
        }

        public int GetCost()
        {
            return campaign.Sum(item => item.Cost());
        }

        public string GetAds()
        {
            var adList = new List<string>();
            campaign.ForEach(ad => adList.Add(ad.ToString()));
            return string.Join("\n", adList);
        }

        public override string ToString()
        {
            return "Advert Campaign\n" + GetAds() + "\n\nTotal Cost = "+ GetCost();
        }
    }
}