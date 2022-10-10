// Console.WriteLine("Первое задание.");
// // Найти расстояние между двумя координатами в 2D пространстве
// Console.WriteLine();

// Console.WriteLine("Введите координаты первой точки X и Y:");
// Console.Write("X: ");
// int firstCoordinateX = int.Parse(Console.ReadLine()!);
// Console.Write("Y: ");
// int firstCoordinateY = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты второй точки X и Y:");
// Console.Write("X: ");
// int secondCoordinateX = int.Parse(Console.ReadLine()!);
// Console.Write("Y: ");
// int secondCoordinateY = int.Parse(Console.ReadLine()!);

// double result = Math.Sqrt(Math.Pow(secondCoordinateX - firstCoordinateX,2) + Math.Pow(secondCoordinateY - firstCoordinateY,2));

// Console.WriteLine($"{result:f2}");

// // ----------------------------------------------------------------------------------------------------------------------------------------------
// Console.WriteLine(); Console.WriteLine();
// Console.WriteLine("Второе задание.");
// // Принимаем на вход положительное число больше 0 и выводим список всех квадратов до него с шагом 1
// Console.WriteLine();

// Console.Write("Введите число N: ");
// int numberN = int.Parse(Console.ReadLine()!);
// for (int i = 1; i < numberN; i++) {
//         Console.Write(Math.Pow(i, 2) + ", ");
// }
// Console.WriteLine(Math.Pow(numberN, 2));

// // ----------------------------------------------------------------------------------------------------------------------------------------------
// Console.WriteLine(); Console.WriteLine();
// Console.WriteLine("Третье задание.");
// // Определить, является ли заданное шестизначное число счастливым. (Счастливым называют такое 
// // шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).
// Console.WriteLine();

// int number;
// do {
//         Console.Write("Введите шестизначное число: ");
//         number = int.Parse(Console.ReadLine()!);
// } while (number < 100000 || 999999 < number);

// int temp;
// int summLeftHalf = 0;
// int summRightHalf = 0;
// for (int i = 0; i < 6; i++) {
//         temp = number % 10;
//         number = number / 10;
//         if (i<3) summRightHalf += temp;
//         else summLeftHalf += temp;
// }

// if (Math.Equals(summLeftHalf,summRightHalf)) Console.WriteLine("Введенное число является счастливым!");
// else Console.WriteLine("Введенное число ТИПО не счастливое!");

// ----------------------------------------------------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------------------------------------------------

// Переменные для ДЗ
int summLeftHalf,summRightHalf,number,temp;
//Домашнее задание
Console.WriteLine(); Console.WriteLine();
Console.WriteLine("Задача №19.");
Console.WriteLine();
String strNumber;
do {
        Console.Write("Введите пятизначное число: ");
        strNumber = Console.ReadLine()!;
} while (strNumber.Length != 5);
number = int.Parse(strNumber);

// Математическое решение(хоть я и не одуплил как можно формулой описать сравнение. Не смог отыскать закономерности. Так что это скорее числовое решение)
Boolean flag = true;
summRightHalf = summLeftHalf = 0;
for (int i = 0; i < 5; i++) {
        temp = number % 10;
        if (i==1 || i==4) temp *=10;
        number = number / 10;
        if (i<2) summRightHalf += temp;
        else if (i>2) summLeftHalf += temp;
}

for (int i = 0; i < 2; i++) {
        if (flag) flag = Math.Equals(summLeftHalf%10, summRightHalf/10);
        temp = summLeftHalf;
        summLeftHalf = summRightHalf;
        summRightHalf = temp;
}

if (flag) Console.Write("Это палиндром");
else Console.Write("Это не палиндром");
Console.WriteLine(" (Math)");

// Решение с использованием строки

flag = true;
for (int i = 0, j = strNumber.Length - 1; i < strNumber.Length / 2; i++, j--)
{
         if (flag) flag = String.Equals(strNumber[i], strNumber[j]);
}

if (flag) Console.Write("Это палиндром");
else Console.Write("Это не палиндром");
Console.Write(" (String)");

// ----------------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine(); Console.WriteLine();
Console.WriteLine("Задача №21.");
Console.WriteLine();

Console.WriteLine("Введите координаты первой точки X, Y и Z:");
Console.Write("X: ");
int firstCoordinateX = int.Parse(Console.ReadLine()!);
Console.Write("Y: ");
int firstCoordinateY = int.Parse(Console.ReadLine()!);
Console.Write("Z: ");
int firstCoordinateZ = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки X, Y и Z:");
Console.Write("X: ");
int secondCoordinateX = int.Parse(Console.ReadLine()!);
Console.Write("Y: ");
int secondCoordinateY = int.Parse(Console.ReadLine()!);
Console.Write("Z: ");
int secondCoordinateZ = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(secondCoordinateX - firstCoordinateX,2) + Math.Pow(secondCoordinateY - firstCoordinateY,2) + Math.Pow(secondCoordinateZ - firstCoordinateZ,2));

Console.WriteLine($"{result:f2}");