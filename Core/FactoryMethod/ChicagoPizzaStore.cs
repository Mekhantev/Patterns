namespace Core.FactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza()
        {
            return new ChicagoPizza();
        }
    }
}