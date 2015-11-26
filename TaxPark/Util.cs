using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark
{
    static class Util
    {
        public static void Price(List<TaxAvto> taxi)
        {
            double priceResult=0;

            for(int i=0;i<taxi.Count;i++)
            {
                priceResult +=taxi[i].price;

                
            }
            Console.WriteLine("The Park costs :" + priceResult);

        }
        public static void ShowList(List<TaxAvto> taxi)
        {
            for (int i = 0; i < taxi.Count; i++)
            {
                Console.WriteLine(i + 1 + ":");
                Console.WriteLine("Name: " + taxi[i].model);
                Console.WriteLine("Type: " + taxi[i].type);
                Console.WriteLine("Fuel: " + taxi[i].fueltype);
                Console.WriteLine("Fuel Cunsumption: " + taxi[i].fuelConsumption);
                Console.WriteLine("Price: " + taxi[i].price);
                Console.WriteLine("Seat Count: " + taxi[i].seatCount);           


            }
        }
        public static void ShowSortedListbyConsumption(List<TaxAvto> taxi)
        {

         taxi.Sort((p1, p2) => p1.fuelConsumption.CompareTo(p2.fuelConsumption));

            Console.WriteLine("Sorted by fuelComsumtion : ");
            
            for (int i = 0; i < taxi.Count; i++)
            {
                Console.WriteLine(i + 1 + ":");
                Console.WriteLine("Name: " + taxi[i].model);
                Console.WriteLine("Type: " + taxi[i].type);
                Console.WriteLine("Fuel: " + taxi[i].fueltype);
                Console.WriteLine("Fuel Cunsumption: " + taxi[i].fuelConsumption);
                Console.WriteLine("Price: " + taxi[i].price);
                Console.WriteLine("Seat Count: " + taxi[i].seatCount);

            }

        }

        public static void Searchby(List<TaxAvto> taxi)
        {
            int choice=0;
            Console.WriteLine("Search :");
            Console.WriteLine("1.By price:");
            Console.WriteLine("2.By Fuelconsumption :");
            Console.WriteLine("3.By Fueltype:");
            Console.WriteLine("4.By model:");

            choice =Int32.Parse(Console.ReadLine());

            while(true)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter price :");
                        break;
                    case 2:
                        Console.WriteLine("Fuelconsumption :");
                        break;
                    case 3:
                        Console.WriteLine("Enter Fueltype:");
                        break;
                    case 4:
                        Console.WriteLine("Enter model:");
                        break;
                    default:
                        break;
                }
                }

           

        }

        }
    }

