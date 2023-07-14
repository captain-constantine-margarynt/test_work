using System;
using static System.Console;
Clear();
WriteLine("Введите через пробел элементы массива и нажмите ENTER: ");
string phrase = ReadLine();

string[] words = phrase.Split(' ');

WriteLine();
WriteLine("Вы ввели: ");
Console.WriteLine(String.Join(", ", words));

int counter = 0; 
foreach (string s in words) {
    if (s.Length <= 3){
    counter++;
    } 
}

WriteLine(counter);

string [] result = new string [counter];
int i =0;
foreach(string s in words){
    if (s.Length <= 3){
        result[i] = s;
        i++;
}
}

WriteLine();
WriteLine("Новый массив: ");
Console.WriteLine(String.Join(", ", result));