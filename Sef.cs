namespace PizzaKemence
{
       internal class Sef
       {
              private PizzaKemence pizzaKemence;
              private static Random r = new Random();
              private static string[] pizzaNevek = { "Margherita", "Pepperoni", "Hawaii", "Vegetariana", "Quattro Formaggi" };

              public Sef(PizzaKemence pizzaKemence)
              {
                     this.pizzaKemence = pizzaKemence;
              }

              public void FeladPizza()
              {
                     while (true)
                     {
                            Thread.Sleep(2000);
                            string nev = pizzaNevek[r.Next(0, pizzaNevek.Length)];
                            int meret = r.Next(20, 41);
                            Pizza pizza = new Pizza(nev, meret);

                            pizzaKemence.FeladPizza(pizza);
                            Console.WriteLine($"Sef feladta: {pizza}");
                     }
              }
       }      
}