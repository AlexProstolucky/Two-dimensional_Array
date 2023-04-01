
internal class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        var rand = new Random(); 
        Console.WriteLine("Множення матриць");
        Console.WriteLine("Введіть розмір матриць:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[,] matrix1 = new int[size,size],
            matrix2 = new int[size,size],
            result = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix1[i,j] = rand.Next(1, 11);
                matrix2[i,j] = rand.Next(1, 11);
                result[i,j] = 0;
            }
        }
    
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    //matrix3[i, j] = matrix3[i, j] + matrix1[i, k] * matrix2[k, j];
                    result[i,j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        Console.WriteLine("\n First matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{matrix1[i,j]}\t");
            }
            Console.WriteLine("\n");
        }
        Console.WriteLine("\n Second matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{matrix2[i, j]}\t");
            }
            Console.WriteLine("\n");
        }
        Console.WriteLine("\n Result of multiply:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{result[i, j]}\t");
            }
            Console.WriteLine("\n");
        }
    }
}