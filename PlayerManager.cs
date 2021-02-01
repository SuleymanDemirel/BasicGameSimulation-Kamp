using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameSimulation
{
     class PlayerManager
    {
        public void Add( Player player)
        {

            Console.WriteLine("Player is registered : " + player.FirstName);
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Player is deleted : " + player.FirstName);
        }
        public void Update(Player player)
        {
            Console.WriteLine("Player is updated : " + player.FirstName);
        }
    }
}
