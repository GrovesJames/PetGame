using System;


namespace VirtualPetAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("Welcome to Virtual Pets!\n");
            Console.WriteLine("Start a new game by pressing enter..");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("\nCreate a pet!\n");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");

            Console.WriteLine("Whats the name for your pet?");
            string name = Console.ReadLine();

            Console.WriteLine("Whats the species of your pet?");
            string species = Console.ReadLine();

            Pet pet = new Pet(name, species);
            bool inGame = true;

            while (inGame)
            {
                Console.Clear();
                Console.WriteLine("----------------");
                Console.WriteLine("----------------");
                Console.WriteLine("\nChoose an option to interact with your pet!");
                Console.WriteLine("\n1. View pets info (name, species)");
                Console.WriteLine("2. View pets status levels");
                Console.WriteLine("3. Feed your pet");
                Console.WriteLine("4. Play with your pet");
                Console.WriteLine("5. Take pet to the doctor\n");
                Console.WriteLine("0. Exit the game");
                Console.WriteLine("----------------");
                Console.WriteLine("----------------");
                string menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    Console.WriteLine("Your pets name is " + pet.Name + " and its species is a " + pet.Species + "!");
                    Console.WriteLine("\nPress enter to continue..");
                    Console.ReadLine();
                }
                else if (menuChoice == "2")
                {
                    Console.WriteLine("Your pets status levels are:");
                    Console.WriteLine("Hunger: " + pet.Hunger);
                    Console.WriteLine("Health: " + pet.Health);
                    Console.WriteLine("Boredom: " + pet.Boredom);
                    Console.WriteLine("\nPress enter to continue..");

                    Console.ReadLine();
                }
                else if (menuChoice == "3")
                {
                    pet.FeedPet();
                }
                else if (menuChoice == "4")
                {
                    pet.PlayPet();
                }
                else if (menuChoice == "5")
                {
                    pet.DoctorPet();
                }
                else if (menuChoice == "0")
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Thats not a choice, silly goose");
                    Console.WriteLine("\nPress enter to continue..");
                    Console.ReadLine();

                }
            }
        }
    }
}
