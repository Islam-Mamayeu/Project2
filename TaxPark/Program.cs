﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int ch = 0;
            bool b = true;
            bool isInt;

                while (b)
                {
                    Console.WriteLine("\n1.Print taxi list");
                    Console.WriteLine("2.Price of TaxPark");
                    Console.WriteLine("3.Print list sorted by FuelConsumption ");
                    Console.WriteLine("4.Search avto");
                    Console.WriteLine("5.Exit\n");

                    List<TaxAvto> taxi = new List<TaxAvto>();

                    taxi.Add(new TaxAvto("Mercedes", "Minivan", "Diesel", 15.5, 10000, 7));
                    taxi.Add(new TaxAvto("Toyota", "sedan", "Gas", 11.5, 100000, 5));
                    taxi.Add(new TaxAvto("Dodge", "Minivan", "Gas", 12.5, 100000, 7));
                    taxi.Add(new TaxAvto("Lada", "sedan", "Backlagan", 8.5, 5000, 5));
                    taxi.Add(new TaxAvto("Audio", "Hatchback", "Gas", 17, 12000, 5));
                    taxi.Add(new TaxAvto("Chrysler", "Minivan", "Gas", 16.7, 11000, 6));

                    isInt = Int32.TryParse(Console.ReadLine(), out ch);

                    if (isInt)
                    {

                        switch (ch)
                        {
                            case 1:
                                Util.ShowList(taxi);
                                break;
                            case 2:
                                Util.Price(taxi);
                                break;
                            case 3:
                                Util.ShowSortedListbyConsumption(taxi);
                                break;
                            case 4:
                                Util.SearchBy(taxi);
                                break;                        
                            case 5:
                                b = false;
                                break;
                            default:
                                Console.WriteLine("Incorrect choice");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please try again!:");
                    }
                }
            }



            }

        }
    
