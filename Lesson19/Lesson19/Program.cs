using Lesson19.Models;
using System;
using System.Collections.Generic;

namespace Lesson19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson 19 extention methods");

            int integer1 = 6;
            int integer2 = -3;

            Console.WriteLine(integer1.PositiveNumber());
            Console.WriteLine(integer2.PositiveNumber());
            Console.WriteLine();

            Console.WriteLine(integer1.EvenNumber());
            Console.WriteLine(integer2.EvenNumber());
            Console.WriteLine();

            Console.WriteLine(integer1.BigerNumberThenThis(5));
            Console.WriteLine(integer2.BigerNumberThenThis(-3));
            Console.WriteLine();

            string testString = "jwqfyeg qkfhkequgf ";
            Console.WriteLine(testString.StringHasSpaces());
            string testString2 = "jwqfyegqkfhkequgf";
            Console.WriteLine(testString2.StringHasSpaces());
            Console.WriteLine();

            Console.WriteLine(testString2.GenerateEmail("audriusbukis",1985,"gmail.com"));
            Console.WriteLine();

            var testList1 = new List<int>() { 1, 5, 6, 9, 8, 7, 6, 30 };
            foreach (var item in testList1.EveryOtherWord())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(testList1.FindAndReturnIfEqual(9));
            Console.WriteLine(testList1.FindAndReturnIfEqual(20));
            Console.WriteLine();

            /* 
              1) Parašykite extension metodą sveikiesiems skaičiams, kuris grąžins bool tipo kintamąjį nusakantį ar skaičius buvo teigiamas ar ne.
              2) Parašykite extension metodą sveikiesiems skaičiams, kuris grąžins bool tipo kintamąjį nusakantį ar skaičius buvo lyginis ar ne.
              3) Parašykite extension metodą sveikiesiems skaičiams, kuris grąžins bool tipo kintamąjį nusakantį ar skaičius perduotas per parametrą yra didesnis ar ne.
              4) Parašykite extension metodą string tipui, kuris grąžins bool tipo kintamąjį nusakantį ar sakinyje yra tarpų ar ne.
              5) Parašykite extension metodą string tipui su parametrais fullname, yearOfBirth ir domain, metodas grąžins rezultatą kaip el. pašto adresą. Pvz.: “vardenispavardenis1990@gmail.com”
              
              6) Parašykite extension metodą FindAndReturnIfEqual List<T> tipui, kuris priimtu T tipo objektą kaip parametrą ir grąžintų tokį patį, jeigu sąraše jis egzistuoja.
              7) Parašykit extension metodą EveryOtherWord List<T> tipui, kuris grąžintų sąrašą sudaryta iš kas antro elemento.
              8) Ar pavyktų sukurti extension metodų System.IO.File klasėi? Pavyzdžiui norint sukurt funkcionalumą grąžinantį kas antrą eilutę iš tekstinio failo.
            */
        }
    }
}
