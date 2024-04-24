using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Address
    {

            public string Country { get; set; }
            public string City { get; set; }
            public string District { get; set; }
            public string Street { get; set; }
            public string House { get; set; }
            public string Building { get; set; }
            public string ApartmentNumber { get; set; }

        public override string ToString()
        {
            return $"{Country}; {City}; {District}; {Street}; {House}; {Building}; {ApartmentNumber}.";
        }
    }
}
