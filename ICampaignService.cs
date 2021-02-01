using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameSimulation
{
    interface ICampaignService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
