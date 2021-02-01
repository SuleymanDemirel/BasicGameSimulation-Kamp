using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameSimulation
{
    class NewMemberCampaign : ICampaignService
    {
        public void Add(Game game)
        {
            Console.WriteLine("%20 Discount campaign in : "+ game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("%20 Discount campaign DELETED : " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("%20 Discount campaign UPDATED : " + game.GameName);
        }
    }
}
