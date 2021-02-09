using System;

namespace Homework03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arrayLength = Console.ReadLine();
            var arr = new int[int.Parse(arrayLength)];
            var oddNumbersArray = new object[int.Parse(arrayLength)];
            var oddNumberArrayUppercaseItems = 0;
            var evenNumbersArrayUppercaseItems = 0;
            var evenNumbersArray = new object[int.Parse(arrayLength)];
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 27);

                if (arr[i] % 2 == 0)
                {
                    evenNumbersArray[i] = arr[i];
                }
                else
                {
                    oddNumbersArray[i] = arr[i];
                }
            }

            object[] ConvertNumbersToLettes(object[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        array[i] = alphabet[(int)array[i] - 1];
                        switch (array[i])
                        {
                            case 'a':
                            case 'e':
                            case 'i':
                            case 'd':
                            case 'h':
                            case 'j':
                                array[i] = array[i].ToString().ToUpper();
                                break;
                        }
                    }
                }

                return array;
            }

            oddNumbersArray = ConvertNumbersToLettes(oddNumbersArray);
            evenNumbersArray = ConvertNumbersToLettes(evenNumbersArray);

            for (int i = 0; i < oddNumbersArray.Length; i++)
            {
                if (oddNumbersArray[i] != null && char.IsUpper(Convert.ToChar(oddNumbersArray[i])))
                {
                    oddNumberArrayUppercaseItems++;
                }
            }

            for (int i = 0; i < evenNumbersArray.Length; i++)
            {
                if (evenNumbersArray[i] != null && char.IsUpper(Convert.ToChar(evenNumbersArray[i])))
                {
                    evenNumbersArrayUppercaseItems++;
                }
            }

            void PrintArrayToConsole(object[] array)
            {
                var str = string.Join(" ", array);
                Console.WriteLine(str);
            }

            PrintArrayToConsole(oddNumbersArray);
            PrintArrayToConsole(evenNumbersArray);

            if (oddNumberArrayUppercaseItems > evenNumbersArrayUppercaseItems)
            {
                Console.WriteLine("\nArray with biggest amount of uppercase items is: oddNumbersArray");
            }
            else
            {
                Console.WriteLine("\nArray with biggest amount of uppercase items is: evenNumbersArray");
            }
        }
    }
}
