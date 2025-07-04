using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class BusinessInfluencer : Influencer
    {
        private const double BIEngagementRate = 3.0;
        private const double Factor = 0.15;
        public BusinessInfluencer(string username, int followers) 
            : base(username, followers, BIEngagementRate)
        {

        }
        public override int CalculateCampaignPrice()
        {
            return (int)(base.CalculateCampaignPrice() * Factor);
        }
    }
}
