//Задача 1: Подсчет суммы четных чисел от 1 до N. Напишите программу, используя цикл, которая находит сумму всех четных чисел в диапазоне от 1 до
//заданного числа N.
void Main(){
System.Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = SumD(N);
System.Console.WriteLine(a);
}
int SumD(int N){
    int[] arr = new int[N+1];
    int sum=0;
    for(int i = 0; i<arr.Length; i++){
        arr[i] = i;
        if(arr[i]%2 == 0){
            sum += arr[i];
        }
    }
    return sum; 
}

Main();