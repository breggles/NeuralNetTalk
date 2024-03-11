using static System.Console;
using static System.Math;

// Step 1: Define the function
//
double f(double x, double w) => w * x;

// Step 2: Define the data set
//
int input = 1;
int expected_output = 2;

// Step 3: Pick a random start value for w ('w' for weight)
//
var w = 0.5;

// Step 4: Calculate actual output
//
var y = f(input, w);

// Step 5: Compare actual output with expected output
//
// ...
// How do we do that? Find the difference between the two

// for (int i = 0; i < 130; i++)
// {
//     var y = f(input, w);
//     WriteLine($"y = w * x = {w} * {input} = {y}");

//     ReadKey();

//     var l = loss(f(input, w), expected_output);
//     WriteLine($"loss = (y - expected)^2 = {loss}");

//     ReadKey();

//     var grad = input;
//     WriteLine($"grad = dy/dw = {grad}");

//     ReadKey();

//     w = w + 0.01 * grad;
//     WriteLine($"new w = {w}");
// }

// double loss(double actual, double expected) => Pow(actual - expected, 2);
