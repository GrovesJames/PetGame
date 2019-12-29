using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAmok
{
    public class Organic : Pet
    {
        public int Health { get; set; }
        public int Hunger { get; set; }

        public Organic() : base()
        {
            Health = 5;
            Hunger = 5;
            MakeUp = "Organic";
        }
        public override void FeedPet()
        {
            Hunger--;
        }
        public override void DoctorPet()
        {
            Health++;
        }
        public override void StatsPet()
        {
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("| Name     | Hunger | Boredom | Health |");
                Console.WriteLine("------------------------------------------\n");
                Console.WriteLine("| " + Name + "     | " + Hunger + "     | " + Boredom + "      | " + Health + "     |\n");
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}