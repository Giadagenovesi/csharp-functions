namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");




            //FUNCTIONS

            //void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.
            void PrintArray(int[] array)
            {
                Console.Write("[");

                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Console.Write(array[i]);
                    }
                }

                Console.WriteLine("]");
            }

        }
    }
}