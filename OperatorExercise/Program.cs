using OperatorExercise;

Console.WriteLine("--------------------------------Exercise 1------------------------------------");
Console.WriteLine();

int a = 17;
int b = 4;
int quotient = a / b;
int remainder = a % b;

if (a == 17 && b == 4)
{
    Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
}
else
{
    Console.WriteLine("False");
}


Console.WriteLine();
Console.WriteLine("--------------------------------Exercise 2------------------------------------");
Console.WriteLine();

Methods.AreaOfCircle();

Console.WriteLine();
Console.WriteLine("--------------------------------Thought Exercise------------------------------------");
Console.WriteLine();

//The equation below outputs 16. The ++i will calculate before k is calcuated and therefore its value is 3+1=4. The j++ will not
//calculate until after k calculates (for the next time) and therefore its value remains 4. That will make k's calculation become 
//4*4=16

var i = 3;
var j = 4;
var k = ++i * j++;

Console.WriteLine(k);
