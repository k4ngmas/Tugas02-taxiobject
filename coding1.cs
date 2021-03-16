using System;


namespace Program
{
    public class coding1
    {
        public string drivername { get; set; }
        public bool onduty { get; set; }
        public int numpassenger { get; set; }
        
        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver :{0}", drivername);
            if (onduty == true)
            {
                Console.WriteLine("Taxi On Duty : Yes");
            }
            if (onduty == false)
            {
                Console.WriteLine("Taxi On Duty : No");
            }
            Console.WriteLine("Jumlah Of Penumpang: {0}", numpassenger);
        }

        public void pickuppassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", drivername);
        }
        public void dropoffpassenger()
        {
            Console.WriteLine("{0} Selesai Mengantarkan Penumpang", drivername);
        }
    }
}
