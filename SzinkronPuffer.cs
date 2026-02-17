namespace PizzaKemence;
       internal class SzinkronPuffer<T>
       {
              private Queue<T> sor;
              private int maxMeret;
              private readonly object zar = new object();

              public SzinkronPuffer(int maxMeret)
              {
                     this.maxMeret = maxMeret;
                     sor = new Queue<T>();
              }

              public void Hozzaad(T elem)
              {
                     lock (zar)
                     {
                            while (sor.Count == maxMeret)
                            {
                                   Monitor.Wait(zar);
                            }
                            sor.Enqueue(elem);
                            Monitor.PulseAll(zar);
                     }
              }

              public T Kivesz()
              {
                     lock (zar)
                     {
                            while (sor.Count == 0)
                            {
                                   Monitor.Wait(zar);
                            }
                            T elem = sor.Dequeue();
                            Monitor.PulseAll(zar);
                            return elem;
                     }
              }
       }