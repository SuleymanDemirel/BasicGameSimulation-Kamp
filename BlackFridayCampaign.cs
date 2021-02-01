using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameSimulation
{
    class BlackFridayCampaign : ICampaignService
    {
        public void Add(Game game)
        {
            Console.WriteLine("%50 Discount in : " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("%50 Discount {0} Campaign is DELETED ", game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("%50 Discount {0} Campaign is UPDATED ", game.GameName);
        }
    }
}
