using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
           //Car auto1 = new Car();
           // Bicycle rower1 = new Bicycle();

           // auto1.Ride();
           // rower1.Ride();
           // rower1.PlayMelody();

           // Skateboard deska1 = new Skateboard();
           // deska1.Ride();

            List<Car> cars = new List<Car>();
            cars.Add(new Car(2010, "Ford"));
            cars.Add(new Car(2016, "Fiat"));
            cars.Add(new Car(2012, "Skoda"));
            cars.Add(new Car(2010, "BMW"));

            cars.Sort();
            foreach (var element in cars)
            {
                Console.WriteLine(element.GetYear()+", "+element.GetBrand());
            }

            //List<int> listaLiczb = new List<int>();
            //listaLiczb.Add(4);
            //listaLiczb.Add(5);
            //listaLiczb.Add(-6);

            //foreach (var element in listaLiczb)
            //{
            //    Console.WriteLine(element);
            //}

            //listaLiczb.Sort();

            //Console.WriteLine("Po sortowaniu");
            //foreach (var element in listaLiczb)
            //{
            //    Console.WriteLine(element);
            //}   

            //for (int i = 0; i < listaLiczb.Count;i++ )
            //{
            //    Console.WriteLine(listaLiczb[i]);
            //}

                Console.ReadKey();
        }


    }
}
