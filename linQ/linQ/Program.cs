using linQ;

internal class Program
{
    static void Main(string[] args)
    {
        List<car> cars = new List<car>
        {
                new car("Lamborghini V2", "Lamborghini", 2015, 100000, 3),
                new car("Honda AH12", "Honda", 1900, 200000, 3),
                new car("Ferrari X1", "Ferrari", 2000, 300000, 3),
                new car("Toyota Povana", "Toyota", 2003, 500000, 3),
                new car("Mustang Mach-e", "Ford", 2021, 600000, 4),
                new car("Bugatti V16", "Bugatti", 2019, 500000, 4),
                new car("Mercedes G-12", "Mercedes", 2004, 200000, 4),
                new car("Audi Olympic", "Audi", 2005, 240000, 5),
                new car("Ford Mustang", "Ford", 1985, 300000, 6)
            };
        var carsInRange = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
        Console.WriteLine("Cac xe co gia trong khoang 100000 den 250000:");
        foreach (var car in carsInRange)
        {
            Console.WriteLine(car.Name + " - " + car.Price);
        }
        var carsAfter1990 = cars.Where(car => car.Year > 1990);
        Console.WriteLine("\nCac xe co nam san xuat >1990:");
        foreach (var car in carsAfter1990)
        {
            Console.WriteLine(car.Name + " - " + car.Year);
        }
        var groupedCars = cars.GroupBy(car => car.Brand)
                          .Select(group => new { Brand = group.Key, TotalPrice = group.Sum(car => car.Price) });
        Console.WriteLine("\nTong gia tri theo hang san xuat:");
        foreach (var group in groupedCars)
        {
            Console.WriteLine(group.Brand + " - " + group.TotalPrice);
        }
        List<truck> trucks = new List<truck> {
                new truck("Volvo FH", "Volvo Trucks", 2002, 300000, "Ryder System, Inc"),
                new truck("Volvo FM", "Volvo Trucks", 2002, 300000, "XPO Logistics, Inc"),
                new truck("Volvo FMX", "Volvo Trucks", 2005, 300000, "XPO Logistics, Inc"),
            };
        var sortedTrucksByYear = trucks.OrderBy(truck => truck.Year);
        Console.WriteLine("\nTruck theo thu tu nam san xuat moi nhat:");
        foreach (var truck in sortedTrucksByYear)
        {
            Console.WriteLine(truck.Name + " - " + truck.Year);
        }
        var ownerCompanies = trucks.Select(truck => truck.OwnerCompany).Distinct();
        Console.WriteLine("\nCac cong ty chu quan cua Truck:");
        foreach (var company in ownerCompanies)
        {
            Console.WriteLine(company);
        }
    }
}
