Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите элементы массива: ");
string[] array = new string[size];

for (int i=0; i,size; i++){
    array[i] = Console.ReadLine()!;
}
string[] newArray = new string[size];

massive(size);
Console.WriteLine("Вывщд массива:");
for (int i=0; i<size; i++){
    if (newArray[i] is not null){
        Console.Write($"{newArray[i]},");
    }
}
void massive(int size){
    for (int i=0; i<size; i++){
        if (array[i].Lenght<=3){
            newArray[i] = array[i];
        }
    }
}