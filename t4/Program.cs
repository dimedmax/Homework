//  Напишите программу, которая на вход принимает натуральное число N
// , а на выходе показывает его цифры через запятую.

int number = 23;

int first_digit = number / 10;
int last_digit = number % 10;

Console.WriteLine(first_digit +","+ last_digit);
