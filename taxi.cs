using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Taxii
{
    class taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name          : {0}", DriverName);
            Console.WriteLine("On Duty              : {0}", OnDuty);
            Console.WriteLine("Number Of Passengeer : {0}\n", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang\n", DriverName);
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
                taxi taxi = new taxi();

                taxi.DriverName = "Hanip";
                taxi.OnDuty = true;
                taxi.NumPassenger = 10;

                taxi.TaxiInfo();
                taxi.PickUpPassenger();
                taxi.DropOffPassenger();

                Console.ReadKey();
            }
        }
    }

