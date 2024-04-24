using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Apartment
    {
        public double Area { get; set; }
        public int Rooms { get; set; }
        public string Options { get; set; }
        public int YearBuilt { get; set; }
        public string MaterialType { get; set; }
        public int Floor { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }

        public static void GenerateApartments( ref List<Apartment> list)
        { 
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                var apartment = new Apartment
                {
                    Area = rand.Next(60,200),
                    Rooms = rand.Next(1,7),
                    Options = "Kitchen, Bathroom, Toilet, Basement, Balcony",
                    YearBuilt = rand.Next(1988,DateTime.Now.Year),
                    MaterialType = "Brick",
                    Floor = rand.Next(1,12),
                    Price = rand.Next(200000,600000),
                    Address = new Address
                    {
                        Country = "Russia",
                        City = "Moscow",
                        District = "District " + (i % 10 + 1),
                        Street = "Street " + (i % 10 + 1),
                        House = (i % 10 + 1).ToString(),
                        Building = (i % 10 + 1).ToString(),
                        ApartmentNumber = (i % 100 + 1).ToString()
                    }.ToString()
                };

                list.Add(apartment);
            }

        } 
    }
}
