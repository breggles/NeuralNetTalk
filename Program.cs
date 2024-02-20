using static System.Console;
using static System.Math;

var w = 0.5;

int x = 1;
int[] ys = [2];

for (int i = 0; i < 130; i++)
{
    WriteLine($"w = {w}");
    WriteLine($"x = {x}");
    var y = w * x;
    WriteLine($"y = w * x = {w} * {x} = {y}");
    var loss = Pow(y - ys[0], 2);
    WriteLine($"loss = (y - expected)^2 = {loss}");
    var grad = x;
    WriteLine($"grad = dy/dw = {grad}");
    w = w + 0.01 * grad;
    WriteLine($"new w = {w}");
}
