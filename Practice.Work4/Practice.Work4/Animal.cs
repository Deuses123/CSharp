using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work4
{
    abstract class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public abstract string TypeOfFood { get; }
        public abstract double CalculateFoodAmount();

        public override string ToString()
        {
            return $"{ID}: {Name}, {TypeOfFood} ({CalculateFoodAmount()} кг)";
        }
    }

    class Carnivore : Animal
    {
        public override string TypeOfFood => "Хищник";

        public override double CalculateFoodAmount()
        {
            return 2.0;
        }
    }

    class Omnivore : Animal
    {
        public override string TypeOfFood => "Всеядное";

        public override double CalculateFoodAmount()
        {
            return 1.5;
        }
    }

    class Herbivore : Animal
    {
        public override string TypeOfFood => "Травоядное";

        public override double CalculateFoodAmount()
        {
            return 3.0;
        }
    }
}
