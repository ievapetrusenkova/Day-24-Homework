
// Day 24 Homework.
SortedList<string, double> productPricePage = new SortedList<string, double>();
productPricePage.Add("milk", 2.12);
productPricePage.Add("bread", 3.25);
productPricePage.Add("coffee", 17.5);
productPricePage.Add("tea", 2.89);
productPricePage.Add("eggs", 1.46);
productPricePage.Add("meat", 28.3);
productPricePage.Add("fish", 21.55);
productPricePage.Add("chocolate", 6.13);

Console.WriteLine($" List of products: \n");

    var totalProducts = productPricePage.ToList();

foreach (var totalItems in totalProducts)
{ 
    Console.WriteLine($" {totalItems.Key} : {totalItems.Value}");
    
}

Console.WriteLine("===========================================");
Console.Write("Enter the price of the selected product : ");
double enteredPrice;
enteredPrice = Convert.ToDouble(Console.ReadLine());

double[] euroCoins = { 2, 1, 0.5, 0.1, 0.05, 0.02, 0.01 };
double receivedChange, receivedAmount, count,  i;
Console.Write("Enter your sum of money to pay for chosen product : ");
receivedAmount = Convert.ToDouble(Console.ReadLine());
receivedChange = (receivedAmount - enteredPrice);
double change = Math.Round(receivedChange, 2);

Console.WriteLine($" Your change is {change}");
for (i = 0; i < euroCoins.Length; i++)
{
    count = change / euroCoins[(int)i];
    
    if (count != 0)
    {
        
        Console.WriteLine("Count of {0}eur coins :{1}", euroCoins[(int)i], Math.Floor(count));
    change %= euroCoins[(int)i];
}
}
   
Console.ReadLine();
Console.WriteLine("==========================");


