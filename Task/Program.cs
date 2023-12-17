/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] 
*/

string[] Array1 = new string[11] {"Hello", "Сat", "World", ":-)", "1234", "567", "-2",
                                 "Computer science", "Russia", "Denmark", "Kazan"};
string[] Array2 = new string[Array1.Length];
void SecondArray(string[] array2, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
        if(Array1[i].Length <= 3)
        {
            Array2[count] = Array1[i];
            count++;

        }
    }
}


    
                                 

