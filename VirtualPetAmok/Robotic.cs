using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAmok
{
    public class Robotic : Pet
    {
        public int Oil { get; set; }
        public int Performance { get; set; }

        public Robotic() : base()
        {
            Oil = 5;
            Performance = 5;
            MakeUp = "Robotic";
        }

        public override void FeedPet()
        {
            Oil++;
        }
        public override void DoctorPet()
        {
            Performance++;
        }
        public override void StatsPet()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| Name     | Oil | Boredom | Performance |");
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("| " + Name + "     | " + Oil + "     | " + Boredom + "      | " + Performance + "     |\n");
            Console.WriteLine("------------------------------------------");
        }
    }
}