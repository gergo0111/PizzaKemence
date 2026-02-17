namespace PizzaKemence
{
       internal class Futar
       {
              private PizzaKemence kemence;

              public Futar(PizzaKemence kemence)
              {
                     this.kemence = kemence;
              }

              public void Szallit()
              {
                     while (true)
                     {
                            Pizza pizza = kemence.KiveszPizza();
                            Thread.Sleep(pizza.Meret * 100);
                            Console.WriteLine($"Futár kiszállította: {pizza}");
                     }
              }
       }
}