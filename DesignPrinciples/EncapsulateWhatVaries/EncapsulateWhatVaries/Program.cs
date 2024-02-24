

namespace EncapsulateWhatVaries
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizza pizza = new Pizza();
            pizza.Order(Constants.CheesePizza);
            pizza.Order(Constants.ChickenPizza);
            pizza.Order(Constants.VegeterianPizza);


        }
    }
}
