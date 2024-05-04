using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int elementsCount = int.Parse(Console.ReadLine());
        string[] myArray = new string[elementsCount];

        void array(string[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент массива под индексом {i + 1}:");
                myArray[i] = Console.ReadLine();
            }
        }
        string[] symbol(string[] myArray)
        {
            int n = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Length <= 3)
                {
                    n++;
                }
            }
            string[] sim = new string[n];
            int k = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Length <= 3)
                {
                    sim[k] = myArray[i];
                    k++;
                }
            }
            return sim;

        }
        void PrintArray(string[] myArray)
        {
            Console.Write("[");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}");
            }
            Console.Write("]");
        }
        array(myArray);
        PrintArray(symbol(myArray));
    }
}