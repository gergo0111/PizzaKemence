namespace PizzaKemence;

class Program
{
    static void Main(string[] args)
    {
        PizzaKemence kemence = new PizzaKemence(5);
        Sef sef = new Sef(kemence);
        Futar futar = new Futar(kemence);

        Thread sefSzal = new Thread(new ThreadStart(sef.FeladPizza));
        Thread futarSzal = new Thread(new ThreadStart(futar.Szallit));

        sefSzal.Start();
        futarSzal.Start();
    }
}

