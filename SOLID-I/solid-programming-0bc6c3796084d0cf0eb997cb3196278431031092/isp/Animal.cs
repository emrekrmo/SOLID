using System;

namespace InterfaceSegregationPrinciple
{
    public class Animal : IAnimal, IOmnivore
    {
        public void Bark()
        {
            throw new NotImplementedException();
        }

        public void Bite()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}