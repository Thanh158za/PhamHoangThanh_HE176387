// See https://aka.ms/new-console-template for more information
Console.Write("Input distance (meters): ");
double distanceInMeters = Convert.ToDouble(Console.ReadLine());
Console.Write("Input time (hours): ");
int hours = Convert.ToInt32(Console.ReadLine());
Console.Write("Input time (minutes): ");
int minutes = Convert.ToInt32(Console.ReadLine());
Console.Write("Input time (seconds): ");
int seconds = Convert.ToInt32(Console.ReadLine());

int totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;
double speedInMetersPerSecond = distanceInMeters / totalTimeInSeconds;
double speedInKilometersPerHour = (distanceInMeters / 1000f) / (totalTimeInSeconds / 3600f);
double speedInMilesPerHour = speedInKilometersPerHour / 1.609f;

Console.WriteLine($"Your speed in meters/sec is {speedInMetersPerSecond:F6}");
Console.WriteLine($"Your speed in km/h is {speedInKilometersPerHour:F5}");
Console.WriteLine($"Your speed in miles/h is {speedInMilesPerHour:F4}");
