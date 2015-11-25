using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark
{
    class TaxAvto :Avto
    {

        private string _type;

        override public void Show()
        {
            Console.WriteLine("Name: "+this.model);
            Console.WriteLine("Type: "+ this._type);
            Console.WriteLine("Fuel: "+this.fueltype);           
            Console.WriteLine("Fuel Cunsumption: " +this.fuelConsumption);
            Console.WriteLine("Price: " +this.price);
            Console.WriteLine("Seat Count: " +this.seatCount);
        }
        public TaxAvto()
        {
            this.model = "Mercedes";
            this.type = "Minivan";
            this.fueltype = "Diesel";
            this.fuelConsumption = 15.5;
            this.price = 100000;
            this.seatCount=8;
        }
        public TaxAvto(string model,string type,string fueltype,double fuelConsumption,int price,int seatCount)
        {
            this.model = model;
            this.type = type;
            this.fueltype = fueltype;
            this.fuelConsumption = fuelConsumption;
            this.price = price;
            this.seatCount = seatCount;
        }
        public double PriceOfPark()
        {
            return 0;

        }
        public string type
        {
            get { return _type; }
            set { this._type = value; }
        }

    }
}
