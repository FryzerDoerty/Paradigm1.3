//Задача 2: Поиск наименьшего числа в списке. Напишите программу, которая находит наименьшее число в заданном списке с помощью цикла.
void Main()
{
    List<int> listen = new List<int>(5) { 24, 25, 346, 2, 5 };
    int a = Max(listen);
    System.Console.WriteLine(a);
}
int Max(List<int> listen)
{
    int min = listen[0];
    for (int i = 1; i < listen.Count; i++)
    {
        if (listen[i] < min)
        {
            min = listen[i];
        }
    }
    return min;
}
Main();