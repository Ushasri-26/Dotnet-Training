using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstDemo
{
    internal class Class1
    {
        Model1Container ob = new Model1Container();
        public void Addpizza()
        {
            Pizzas p = new Pizzas()
            {
                PizzaId = 10,
                Pizzaname = "Corn veg",
                Price = 300,
                Description = "Made with cheese",
                Type = "Veg"
            };
            Model1Container ob = new Model1Container();
            ob.Pizzas.Add(p);
            int i = ob.SaveChanges();
            Console.WriteLine("total record inserted is " + i);

            foreach (var item in ob.Pizzas)
            {
                Console.WriteLine($"{item.PizzaId}  {item.Pizzaname}  {item.Description}  {item.Price}  {item.Type}");
            }

        }
        // extenstion methods

        public void EvenODD()
        {
            int x = 11;
            Console.WriteLine(x.IsEven());


        }

    }
    static class myclass
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

    }
}

