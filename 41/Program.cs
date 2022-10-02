// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Сколько чисел будем вводить?");
int k = Convert.ToInt32(Console.ReadLine());
int[] a = new int[k];
for (int i = 0; i < k; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
int n = 0;
for (int i = 0; i < k; i++)
{
    if (a[i] > 0) n++;
}
Console.WriteLine(n);