// Вид 1

/*void Method1()
{
    Console.WriteLine("Автор Мохнаткина Ольга Петровна");
}

Method1();
*/


// Вид 2

/*void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения");//Программа выше позволяет вызвать значение, соответствующее только аргументу msg
*/

/*void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("Текст сообщения", 5);//Программа выше позволяет вызвать значение указанное число раз
*/

/*void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(count: 5, msg: "Новый текст");//Программа выше позволяет вызвать значение конкретного аргумента, можно менять местами при этом
*/


// Вид 3

/*int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/


// Вид 4

/* Method4(int count, string текст)
{
    int i = 0;
    string result = String.Empty; //результат будет пустой строкой
    while(i < count)
    {
        result = result + текст;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf ");
Console.WriteLine(res);
*/

//Тож же метод с использованием цикла for

/*string Method4(int count, string текст)
{
    
    string result = String.Empty; 
    for(int i = 0; i < count; i++)
    {
        result = result + текст;
    }
    return result;
}

string res = Method4(10, "z ");
Console.WriteLine(res);
*/

//Таблица умножения (от 2 до 10)

/*for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i } * { j} = {i * j}");
    }
}
*/

//Таблица умножения (от 1 до 9)

/*for(int i = 1; i <= 9; i++)
{
    for(int j = 1; j <= 9; j++)
    {
        Console.WriteLine($"{i } * { j} = {i * j}");
    }
    Console.WriteLine();
}
*/


//=======РАБОТА С ТЕКСТОМ

//Задача. Дан текст, в котором все пробелы нужно заменить черточками, 
//маленькие буквы "к" заменить большими "К", а большие "С" заменить малеькими "с".

/*string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"  
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
*/

//string s = "qwerty"
//            012345
//s[3]      //r

/*string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;//пустая строка

    int length = text.Length;//длина строки
    for(int i =0; i < length; i++)
    {
        if(text[i] == oldValue) 
        result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'а', 'А');
Console.WriteLine(newText);
*/

//Вывод только последнего варианта текста

/* Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;//пустая строка

    int length = text.Length;//длина строки
    for(int i =0; i < length; i++)
    {
        if(text[i] == oldValue) 
        result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine();
newText = Replase(newText, 'С', 'с');
Console.WriteLine();
newText = Replase(newText, 'а', 'А');
Console.WriteLine(newText);
*/

//=======РАБОТА С МАССИВОМ 

//Упорядочение от минимального к максимальному

/*int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/

//Упорядочение от максимального к минимальному

/*int[] arr = { 8, 5, 3, 3, 2, 6, 7, 1, 4, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
            maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/
