using System.Net.Security;

(string, int, int) score = ("R2-D2", 12420, 15);
(string, int, int) score2 = ("Luke", 6969, 10);

var score3 = (Name: "Anakin", Points: 420, Level: 69);

Console.WriteLine($"Name:{score.Item1} Level:{score.Item3} Score:{score.Item2}");
Console.WriteLine($"Name:{score2.Item1} Level:{score2.Item3} Score:{score2.Item2}");
Console.WriteLine($"Name:{score3.Name} Level:{score3.Level} Score:{score3.Points}");

double x = 4;
double y = 2;
(x, y) = (y, x);