namespace Core.AbstractFactory
{
    class AnimalWorld
    {
        private IHerbivore _herbivore;
        private ICarnivore _carnivore;

        public AnimalWorld(IContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }
    }
}