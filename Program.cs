using static System.Console;
using static System.Math;

var w = 0.5;
var b = 0.5;

int[] xs = [1];
int[] ys = [2];

for (int i = 0; i < 130; i++)
{
    foreach (var x in xs)
    {
        WriteLine($"w = {w}");
        WriteLine($"x = {x}");
        var y = w * x;
        WriteLine($"y = w * x = {w} * {x} = {y}");
        var loss = Pow(y - ys[0], 2);
        WriteLine($"loss = (y - expected)^2 = {loss}");
        var grad = w;
        WriteLine($"grad = dy/dx = {grad}");
        w = w + 0.01 * grad;
        WriteLine($"new w = {w}");
    }
}
