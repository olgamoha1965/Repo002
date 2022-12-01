//Метод определяет индекс числа 18 (в данном случае их два)

/*int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;

int find = 18;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index + 1;
    index++;
}
*/

//Метод определяет индекс числа 18 (в данном случае после первого числа поиск завершается)

int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;

int find = 18;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
