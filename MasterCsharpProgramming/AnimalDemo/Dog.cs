using static System.Console;

namespace Section8._Inheritance.AnimalDemo
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            WriteLine("Brrrrrrr!");
        }

        public void Bark()
        {
            WriteLine("Barking");
        }
    }
}
