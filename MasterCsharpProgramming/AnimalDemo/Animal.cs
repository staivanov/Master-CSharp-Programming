using Section9.Interfaces.Interfaces;
using static System.Console;

namespace Section8._Inheritance.AnimalDemo
{
    internal class Animal : IAnimal
    {
        public virtual void MakeSound()
        {
            WriteLine("Animal makes a generic sound.");
        }

        public void Eat()
        {
            WriteLine("Eating");
        }

        public void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
