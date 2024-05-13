// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the buying price:");
decimal buyingPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the selling price:");
decimal sellingPrice = Convert.ToDecimal(Console.ReadLine());

decimal profitOrLoss = sellingPrice - buyingPrice;

if (profitOrLoss > 0)
{
    Console.WriteLine("You can book your profit amount: " + profitOrLoss);
}
else if (profitOrLoss < 0)
{
    Console.WriteLine("You have incurred a loss amount: " + Math.Abs(profitOrLoss));
}
else
{
    Console.WriteLine("You have neither made a profit nor incurred a loss.");
}
