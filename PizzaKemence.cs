namespace PizzaKemence
{
       internal class PizzaKemence
       {
              private SzinkronPuffer<Pizza> puffer;

              public PizzaKemence(int maxPizzak)
              {
                     puffer = new SzinkronPuffer<Pizza>(maxPizzak);
              }

              public void FeladPizza(Pizza pizza)
              {
                     puffer.Hozzaad(pizza);
              }

              public Pizza KiveszPizza()
              {
                     return puffer.Kivesz();
              }
       }
}