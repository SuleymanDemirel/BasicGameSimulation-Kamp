using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameSimulation
{
    class GameManager
    {
        public void Add(Game game, Player player)
        {
            Console.WriteLine("Game Added : " + "\n Game : " + game.GameName + " \n  User : " + player.FirstName + 
                "\n Game Category : " + game.GameCategory + "\n Price : " + game.Price );
        }
        public void Delete(Game game, Player player)
        {
            Console.WriteLine("Game Deleted : " + "\n Game : " + game.GameName + " \n  User : " + player.FirstName + 
                "\n Game Category : " + game.GameCategory + "\n Price : " + game.Price );
        }

    }
}
