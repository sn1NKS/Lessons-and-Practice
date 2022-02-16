// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int Number1 = 45;
int Number2 = 76;
if (Number2 % Number1 == 0)
{
    Console.WriteLine("Число кратно " + Number1);
}
else Console.WriteLine("Остаток от деления " + Number2 % Number1);