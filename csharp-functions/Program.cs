namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dichiaro l'array di numeri
            int[] numbersArray = { 2, 6, 7, 5, 3, 9 };

            //Stampo l'array originale
            PrintArray(numbersArray);

            //Elevo al quadrato i numeri dell'array
            PrintArray(SquareNumbersArray(numbersArray));

            //Ristampo l'array originale per essere sicura di non averlo modificato una volta elevati i numeri al quadrato
            PrintArray(numbersArray);


            //Stampo la somma di tutti i numeri
            Console.WriteLine(SumNumbersArray(numbersArray));

            //Stampo la somma di tutti i numeri dell'array al quadrato
            Console.WriteLine(SumSquareNumberArray(numbersArray));



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


            //int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
            int SquareNumber (int number)
            {
                return number * number;
            }

            

            //int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. 
            int[] SquareNumbersArray(int[] array)
            {
                int[] squaredArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    squaredArray[i] = array[i] * array[i];
                
                }
                return squaredArray;
            }


            //int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
            int SumNumbersArray(int[] array)
            {
                int sumResult = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sumResult += array[i];
                }
                return sumResult;

            }


            // SommaElementiArray al quadrato e ne restituisce la somma
            int SumSquareNumberArray(int[] array)
            {
                int sumSquareNumResult = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sumSquareNumResult += array[i] * array[i];
                }

                return sumSquareNumResult;
            }

        }
    }
}