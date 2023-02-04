// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
String num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
Console.WriteLine("Введите второе число: ");
String num2 = Console.ReadLine();
int number2 = Convert.ToInt32(num2);
Console.WriteLine("Введите третье число: ");
String num3 = Console.ReadLine();
int number3 = Convert.ToInt32(num3);
int max = number1;
if(number2>max){
    max=number2;
}
else if(number3>max){
    max=number3;
}
else{
    Console.Write("Тогда х.з..., наверно ");
}
Console.WriteLine("Максимальное число- "+ max);
