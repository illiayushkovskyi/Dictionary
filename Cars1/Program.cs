using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cars1
{
    class CarColection<year, model>
    {
        KeyValuePair<year, model>[] car = new KeyValuePair<year, model>[0];

        public void Add(year year, model value)
        {
            KeyValuePair<year, model>[] newcar = new KeyValuePair<year, model>[car.Length + 1];

            for (int i = 0; i < car.Length; i++)
            {
                newcar[i] = car[i];
            }
            newcar[newcar.Length - 1] = new KeyValuePair<year, model>(year, value);
            car = newcar;
        }
        public int Count
        {
            get { return car.Length; }
        }
        public KeyValuePair<year, model> this[int index]
        {
            get
            {
                if (index >= 0 && index < car.Length)
                    return car[index];
                return default;
            }
        }
        public void Clear()
        {
            if (car.Length > 0)
            {
                car = null;
            }
        }
        public KeyValuePair<year, model> this[model text]
        {
            get
            {
                for (int i = 0; i < car.Length; i++)
                {
                    if (car[i].Value.Equals(text))
                    {
                        return car[i];
                    }
                }
                return default(KeyValuePair<year, model>);
            }
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            CarColection<int, string> myCars = new CarColection<int, string>();
            myCars.Add(2004, "Mazda3");
            myCars.Add(1999, "BMW 320");
            myCars.Add(2008, "Peugeot 307cc");

            Console.WriteLine(myCars[0]);

            for (int i = 0; i < myCars.Count; i++)
            {
                Console.WriteLine(myCars[i]);
            }

            Console.ReadKey();
        }
    }
}
