using System;

namespace BasicGameSimulation
{
    class Program
    {

        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Süleyman";
            player1.LastName = "Demirel";
            player1.BirthYear = 2000;
            player1.TcNo = "12345";

            Player player2 = new Player();
            player2.Id = 2;
            player2.FirstName = "Mert";
            player2.LastName = "Demir";
            player2.BirthYear = 2001;
            player2.TcNo = "4235";

            Player playerControl = new E_Devlet();
            playerControl.FirstName = "Süleyman";
            playerControl.LastName = "Demirel";
            playerControl.BirthYear = 2000;
            playerControl.TcNo = "12345";

            Game game1 = new Game();
            game1.Id = 5;
            game1.GameName = "Counter Strike Global Offansive";
            game1.GameCategory = "War";
            game1.Price = 30;

            Game game2 = new Game();
            game2.Id = 6;
            game2.GameName = "League Of Legends";
            game2.GameCategory = "War, Fight";
            game2.Price = 10;

            PlayerManager playerManager = new PlayerManager();
            if (player1.FirstName == playerControl.FirstName && player1.LastName == playerControl.LastName &&
                player1.BirthYear == playerControl.BirthYear && player1.TcNo == playerControl.TcNo)
            {
                playerManager.Add(player1);
                playerManager.Delete(player1);
                playerManager.Update(player1);
            }
            else
            {
                Console.WriteLine("Error.");
            }

            GameManager gameManager = new GameManager();
            gameManager.Add(game1, player1);
            gameManager.Delete(game2, player2);

            ICampaignService campaignService = new BlackFridayCampaign(); // new NewMemberCampaign
            campaignService.Add(game1);
            campaignService.Delete(game1);
            campaignService.Update(game1);


            Console.ReadLine();

        }
    }
}
