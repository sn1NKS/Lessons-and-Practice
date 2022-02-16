// Удалить вторую цифру трёхзначного числа.
int number = 363;
var str = number.ToString();
number = int.Parse(str.Remove(str.Length - 2, 1));
Console.WriteLine(number);