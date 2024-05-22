namespace VirtualGarage
{
    internal class Program
    {
        static public List<Car> Garage = new List<Car>
        {
            new Car("Mercedes Benz", "A-Class", 2015),
            new Car("Ford", "Focus", 1999)
        };
    static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to your virtual garage! What would you like to do?");
                Console.WriteLine("1. Show Cars");
                Console.WriteLine("2. Add Car");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    showCars();
                } else if (userInput == "2")
                {
                    addCar();
                }
            }
        }

        static void showCars()
        {
            Console.Clear();
            Console.WriteLine("Your Garage!, Press ID of car to remove, or press 'e' to exit");
            for (int i = 0; i < Garage.Count; i++)
            {
                Console.WriteLine($"{i}. {Garage[i].Brand} {Garage[i].Model} {Garage[i].Year}");
            }

            string userInput = Console.ReadLine();
            if (userInput != "e")
            {
                int i = Convert.ToInt32(userInput);
                Console.Clear();
                Console.WriteLine($"{Garage[i].Brand} {Garage[i].Model} {Garage[i].Year} has been removed from your Garage. Press any key to continue");
                Garage.RemoveAt(i);
            }

        }

        static void addCar()
        {
            Console.Clear();
            Console.WriteLine("What is the brand of your Car?");
            string brand = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is the model of your Car?");
            string model = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What year is your Car?");
            string year = Console.ReadLine();
            Console.Clear();
            Garage.Add(new Car(brand, model, Convert.ToInt32(year)));
            Console.WriteLine($"{brand} {model} {year} has been added to your Garage. Press any key to continue");
            Console.ReadKey();
        }
    }

    
}
