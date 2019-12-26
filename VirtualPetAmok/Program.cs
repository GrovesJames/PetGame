using System;

namespace VirtualPetAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOn = true;
            while (gameOn)
            {
                Game game = new Game();

                while (game.GameFinished == false)
                {
                    game.Interact();
                }
                gameOn = false;
            }
        }
    }
}
