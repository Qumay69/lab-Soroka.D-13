//Лаб 7 Вариант 20 Уровень сложности средный

//try
//{
//    Console.Write("Введите количество авиарейсов: ");
//    int n = Convert.ToInt32(Console.ReadLine());
//    Avia[] aviaReisGroup = new Avia[n];

//    for (int i = 0; i < n; i++)
//    {
//        aviaReisGroup[i] = new Avia();
//        Console.Write("Введите номер авиарейса: ");
//        aviaReisGroup[i].FlightNumber = int.Parse(Console.ReadLine());
//        Console.Write("Введите время вылета: ");
//        aviaReisGroup[i].DepartureTime = DateTime.Parse(Console.ReadLine());
//        Console.Write("Введите время прилета: ");
//        aviaReisGroup[i].ArrivalTime = DateTime.Parse(Console.ReadLine());
//        Console.Write("Введите направление: ");
//        aviaReisGroup[i].Destination = Console.ReadLine();
//        Console.Write("Введите марка самолета: ");
//        aviaReisGroup[i].AirplaneModel = Console.ReadLine();
//        Console.Write("Введите растояние");
//        aviaReisGroup[i].Distance = int.Parse(Console.ReadLine());  
//    }
//    int max = 0;
//    TimeSpan maxTimeSpan = TimeSpan.FromMilliseconds(max);

//    foreach (Avia item in aviaReisGroup)
//    {
//        if (item.ArrivalTime - item.DepartureTime > maxTimeSpan)
//        {
//            maxTimeSpan = item.ArrivalTime - item.DepartureTime;
//        }
//    }
//    foreach (Avia item in aviaReisGroup)
//    {
//        if (item.ArrivalTime - item.DepartureTime == maxTimeSpan)
//        {
//            Console.WriteLine();
//            Console.WriteLine($"Номер авиарейса: {item.FlightNumber}");
//            Console.WriteLine($"Время вылета: {item.DepartureTime}");
//            Console.WriteLine($"Время прилета: {item.ArrivalTime}");
//            Console.WriteLine($"Направление: {item.Destination}");
//            Console.WriteLine($"Марка самолета: {item.AirplaneModel}");
//            Console.WriteLine($"Растояние: {item.Distance}");
//            break;
//        }   
//    }
//}
//catch (Exception err) 
//{
//    Console.WriteLine(err.Message);
//}

//struct Avia
//{
//    public int FlightNumber;
//    public DateTime DepartureTime;
//    public DateTime ArrivalTime;
//    public string Destination;
//    public string AirplaneModel;
//    public int Distance;
//}

//Лаб 8 Вариант 4 Уровень cложности базовый

//Задание 1

//DateOnly dateOnly = DateOnly.Parse(Console.ReadLine());

//Date date = new Date();
//date.day = dateOnly.Day;
//date.month = dateOnly.Month;
//date.year = dateOnly.Year;
//Console.WriteLine(date.day);
//Console.WriteLine(date.month);
//Console.WriteLine(date.year);

//struct Date
//{
//    public int day;
//    public int month;
//    public int year;
//}

//Задание 2

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите дату и время производства продукта (гггг-мм-дд чч:мм:сс):");
//        DateTime productionDate = DateTime.Parse(Console.ReadLine());

//        Console.WriteLine("Введите срок годности продукта в часах:");
//        int expiryHours = int.Parse(Console.ReadLine());

//        Product product = new Product { ProductionDate = productionDate, ExpiryHours = expiryHours };

//        TimeSpan timeUntilExpiry = product.ProductionDate.AddHours(product.ExpiryHours) - DateTime.Now;

//        if (timeUntilExpiry.TotalHours > 0)
//        {
//            Console.WriteLine($"До истечения срока годности осталось {timeUntilExpiry.TotalHours} часов.");
//        }
//        else
//        {
//            Console.WriteLine("Срок годности продукта истек.");
//        }
//    }
//}
//struct Product
//{
//   public DateTime ProductionDate;
//   public int ExpiryHours;
//}