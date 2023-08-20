//Задача 4: Поиск уникальных элементов в списке. Напишите программу, которая создает новый список, содержащий только уникальные элементы из //исходного списка.
var all = new[] {25,25,12,13,12,4}.ToList();
var listen = all.GroupBy(i => i).Where(i => i.Count() == 1).SelectMany(i => i);
System.Console.WriteLine("[" + string.Join(",", listen)+"]");