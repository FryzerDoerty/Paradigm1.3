//Императивное программирование:
//Задача 6: Упорядочивание списка. Напишите программу, которая сортирует список чисел в порядке возрастания с использованием пузырьковой сортировки или другого метода сортировки.
void Main(){
     List<int> listen = new List<int>() { 24, 25, 346, 2, 5 };
     //System.Console.WriteLine("["+string.Join(",", listen)+"]");
     Listenin(listen); 
}
void Listenin(List<int> listen){
    int indx;
    for (int i = 0; i < listen.Count; i++){
        indx=i;
        for (int j = i; j < listen.Count; j++){
            if(listen[j]<listen[indx]){
                indx=j;
            }
        }
        if(listen[indx]==listen[i]){
            continue;
        }
        int temp  = listen[i];
        listen[i]=listen[indx];
        listen[indx]= temp;
    }
    System.Console.WriteLine("["+string.Join(",", listen)+"]");
}
Main();

