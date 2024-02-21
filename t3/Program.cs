// Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = 23;

int first_digit = num / 10;
int second_digit = num % 10;

if (first_digit > second_digit){
    Console.WriteLine ( first_digit + " наибольшая цифра");
}
else if (second_digit > first_digit){
    Console.WriteLine ( second_digit + " наибольшая цифра");
}