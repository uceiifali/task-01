// Variables
int priceOfSmallCarpet = 25;
int priceOfLargeCarpet = 35;
double tax = 0.06; 

// Instructions
System.Console.WriteLine("Welcome to Youssef's Carpet Cleaning Service");
System.Console.WriteLine($"Our Prices are {priceOfSmallCarpet:C} for small carpets, {priceOfLargeCarpet:C} for large carpets. Also, there is a {tax:P0} Sales Tax Rate.");
System.Console.WriteLine("For your information, these price estimates are valid for 30 days.");

// Name
Console.Write("Enter Your Name: ");
string customerName = System.Console.ReadLine();

// Number of Small Carpets
Console.Write("Number of Small Carpets: ");
int numberOfSmallCarpet = Convert.ToInt32(System.Console.ReadLine());

// Number of Large Carpets
Console.Write("Number of Large Carpets: ");
int numberOfLargeCarpet = Convert.ToInt32(System.Console.ReadLine());

// Calculations
int totalCost = priceOfSmallCarpet * numberOfSmallCarpet + numberOfLargeCarpet * priceOfLargeCarpet;
double totalWithTax = totalCost + totalCost * tax;

// Output
System.Console.WriteLine($"So Mr/s {customerName}, your cost will be: {totalCost:C} and after adding {tax:P0} tax, your total will be {totalWithTax:C}.");
