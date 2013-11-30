namespace Core.FactoryMethod
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza();

        public Pizza OrderPizza()
        {
            return CreatePizza();
        }
    }
}