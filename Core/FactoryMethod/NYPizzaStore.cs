namespace Core.FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza()
        {
            return new NYPizza();
        }
    }
}