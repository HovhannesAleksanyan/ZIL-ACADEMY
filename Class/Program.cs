using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            car lamborghini = new car();
            lamborghini.color = "red";
            lamborghini.enginetype = "petrol 6 litres";
            lamborghini.seatsquantity = 2;

            bike BMW = new bike();
            BMW.color = "white";
            BMW.enginetype = "petrol 3 litres biturbo ";
            BMW.seatsquantity = 1;
            BMW.wheelquantity = 2;

            train train = new train();
            train.color = "black";
            train.color = "diesel 8 litres";
            train.seatsquantity = 300;
            train.wheelquantity = 20;

            airplane boing = new airplane();
            boing.color = "white";
            boing.enginetype = "10 litres diesel";
            boing.seatsquantity = 100;
            boing.wheelquantity = 3;

            Ship Titanic = new Ship();
            Titanic.color = "white";
            Titanic.enginetype = "turbo diesel 6 litres";
            Titanic.seatsquantity = 100;
            Titanic.wheelquantity = 0;
        }
    }
}
