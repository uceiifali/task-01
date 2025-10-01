// Variables
int priceOfSmallCarpet = 25;
int priceOflargeCarpet = 35;
double tax = 6;

// instractions
System.Console.WriteLine("Wellcome to Youssef's Carpet Cleaning Service");
System.Console.WriteLine("Our Prices is 25$ for small carpets , 35$ for large Carpets. Also there is a 6% Sales Tax Rate.");
System.Console.WriteLine("For Your Information this Prices estimate is 30 days.");

//Name
Console.Write("Enter Your Name: ");
string customerName = System.Console.ReadLine();

//Number of Small Carpet
Console.Write("Number of Small Carpet: ");
int numberOfSmallCarpet = Convert.ToInt32(System.Console.ReadLine());

//Number of Large Carpet
Console.Write("Number of Large Carpet: ");
int numberOfLargeCarpet = Convert.ToInt32(System.Console.ReadLine());

int totalCost = priceOfSmallCarpet * numberOfSmallCarpet + numberOfLargeCarpet * priceOflargeCarpet;
double totalWithTax = totalCost + totalCost * (tax / 100);

System.Console.WriteLine($"So Mr/s {customerName}, Your Cost will be : {totalCost}$ and After Adding {tax}% Tax Your Total Will be {totalWithTax}$ ");
