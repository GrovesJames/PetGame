using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAmok
{
    public class Pet
    {
        public int Boredom { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string MakeUp { get; set; }

        public Pet()
        {
            Boredom = 5;
        }

        public void AddPet(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void InfoPet()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\nPet name: " + Name);
            Console.WriteLine("\nPet species: " + Species);
            Console.WriteLine("\nPet make up: " + MakeUp + "\n");
            Console.WriteLine("------------------------------------------");
        }
        public virtual void StatsPet()
        {
        }
        public void PlayPet()
        {
            Boredom--;
        }
        public virtual void FeedPet()
        {
        }
        public virtual void DoctorPet()
        {
        }
    }
}