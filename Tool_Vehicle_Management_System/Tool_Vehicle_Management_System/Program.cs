using static System.Formats.Asn1.AsnWriter;

namespace Tool_Vehicle_Management_System
{
    // Base Class:

    public abstract class ToolVehicle
    {
        // Properties:

        public int VehicleId;
        public string? RegNo;
        public string? Model;
        public bool TaxStatus;

        // Constructor:

        public ToolVehicle(int VehicleId, string RegNo, string Model, bool taxStatus)
        {
            this.VehicleId = VehicleId;
            this.RegNo = RegNo;
            this.Model = Model;
            this.TaxStatus = taxStatus;
        }

        // Static Properties:

        public static int TotalVehicles;
        public static int TotalTaxPayingVehicles;
        public static int TotalNonTaxPayingVehicles;
        public static decimal TotalTaxCollected;

        // Abstract Method:

        public abstract void PayTax();

        // Methods:

        public void Total_No_Of_Vehicles()
        {
            TotalVehicles++;
            Console.WriteLine($"Total No of Created Vehicles = {TotalVehicles}");
        }

        public void PassWithoutPaying()
        {
            if(TaxStatus == true)
            {
                Console.WriteLine("You Have Already Pay The Tax.");
            }else
            {
                TotalNonTaxPayingVehicles++;
                Console.WriteLine($"Non Tax Paying Vehicles = {TotalNonTaxPayingVehicles}");
            }
        }
    }

    public class Car : ToolVehicle
    {
        // Properties:

        public string? Brand;
        public decimal? Price;
        public string? VehicleType;

        // Constructor:

        public Car(string Brand, decimal Price, string VehicleType, int VehicleId, string RegNo, string Model,bool TaxStatus) : base(VehicleId,RegNo,Model,TaxStatus)
        {
            this.Brand = Brand;
            this.Price = Price;
            this.VehicleType = VehicleType;
        }

        // Abstract Method Implementaion:

        public override void PayTax()
        {
            TotalTaxPayingVehicles += 2;
        }

        // Methods:

        protected void Total_No_Of_Cars_Created()
        {
            TotalVehicles++;
            Console.WriteLine($"Total No of Cars Created = {TotalVehicles}");
        }

        protected void printCarDetails()
        {
            Console.WriteLine($"Brand = {Brand}\nPrice = {Price}$\nVehicle Type = {VehicleType}\nVehicleId = {VehicleId}\nReg No = {RegNo}\nModel = {Model}\nTax Status = {TaxStatus}");
        }
    }

    public class Bike : ToolVehicle
    {
        // Properties:

        public string? Brand;
        public decimal? Price;
        public string? VehicleType;

        // Constructor:

        public Bike(string Brand, decimal Price, string VehicleType, int VehicleId, string RegNo, string Model, bool TaxStatus) : base(VehicleId, RegNo, Model, TaxStatus)
        {
            this.Brand = Brand;
            this.Price = Price;
            this.VehicleType = VehicleType;
        }

        // Abstract Method Implementaion:

        public override void PayTax()
        {
            
            TotalTaxPayingVehicles++;
        }

        // Methods:

        protected void Total_No_Of_Bikes_Created()
        {
            TotalVehicles++;
            Console.WriteLine($"Total No of Bikes Created = {TotalVehicles}");
        }

        protected void printBikeDetails()
        {
            Console.WriteLine($"Brand = {Brand}\nPrice = {Price}$\nVehicle Type = {VehicleType}\nVehicleId = {VehicleId}\nReg No = {RegNo}\nModel = {Model}");
        }
    }

    public class HeavyVehicle : ToolVehicle
    {
        // Properties:

        public string? Brand;
        public decimal? Price;
        public string? VehicleType;

        // Constructor:

        public HeavyVehicle(string Brand, decimal Price, string VehicleType, int VehicleId, string RegNo, string Model, bool TaxStatus) : base(VehicleId, RegNo, Model, TaxStatus)
        {
            this.Brand = Brand;
            this.Price = Price;
            this.VehicleType = VehicleType;
        }

        // Abstract Method Implementaion:

        public override void PayTax()
        {
            TotalTaxPayingVehicles += 4;
            Console.WriteLine($"Heavy Vehicle Tax Rate = {TotalTaxPayingVehicles}$");
        }

        // Methods:

        protected void Total_No_Of_HeavyVehicles_Created()
        {
            TotalVehicles++;
            Console.WriteLine($"Total No of HeavyVehicles Created = {TotalVehicles}");
        }

        protected void printHeavyVehicleDetails()
        {
            Console.WriteLine($"Brand = {Brand}\nPrice = {Price}$\nVehicle Type = {VehicleType}\nVehicleId = {VehicleId}\nReg No = {RegNo}\nModel = {Model}\nTax Status = {TaxStatus}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Car Objects:

            Car car = new("Toyota", 24000m, "Sedan", 12345, "ABC1234", "Camry", true);

            Car car1 = new("Ford", 27000m, "SUV", 23456, "GHI9012", "Escape", true);

            Car car2 = new("Chevrolet", 30000m, "SUV", 67890, "JKL3456", "Equinox",false);

            // Bike Objects:

            Bike bike = new("Yamaha",8499m,"Sport", 12345, "XYZ9871", "YZF-R3",true);


            Bike bike1 = new("Honda", 9999m, "Cruiser", 56789, "ABC1234", "Rebel 500", true);

            Bike bike2 = new("Suzuki", 7299m, "Adventure", 23456, "DEF4567", "V-Strom 650", false);
            bike2.PassWithoutPaying();

            // Heavy Vehicles Objects:

            HeavyVehicle heavyvehicle = new("Volvo", 120000m, "Truck", 12345, "TRK9871", "VNL Series",true);

            HeavyVehicle heavyvehicle1 = new("Caterpillar", 250000m, "Excavator", 56789, "EXC1234", "336 Hydraulic Excavator", true);

            HeavyVehicle heavyvehicle2 = new("Komatsu", 300000m, "Bulldozer", 34567, "BLD0123", "D155AX-8", false);

        }
    }
}
