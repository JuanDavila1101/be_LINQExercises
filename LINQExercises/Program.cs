using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////

      // LINQ
      // LINQ Sorting Operations

      var numbers = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };
      // OrderBy, OrderByDescending, and Reverse

      //foreach(int num in numbers)
      //{
      //  Console.WriteLine(num);
      //}

      Console.WriteLine($"Original {string.Join(',', numbers)}");

      var orderedNumbers = numbers.OrderBy(num => num);
      //Console.WriteLine("Ordered", orderedNumbers);
      Console.WriteLine($"Ordered {string.Join(',', orderedNumbers)}");

      var orderedDescendingNumbers = numbers.OrderByDescending(num => num);
      //Console.WriteLine("Descending", orderedNumbers);

      Console.WriteLine($"Descending order Numbers {string.Join(',', orderedDescendingNumbers)}");

      numbers.Reverse();
      //Console.WriteLine("Reverse", numbers);
      Console.WriteLine($"Reverse {string.Join(',', numbers)}");



      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////
      /// LINQ Agregate function
      var numbers2 = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };
      Console.WriteLine($"Ordered {string.Join(',', numbers2)}");

      var maxNumber = numbers2.Max();
      Console.WriteLine(maxNumber);

      var sumOfNumbers = numbers2.Sum();
      Console.WriteLine(sumOfNumbers);

      var average = numbers2.Average();
      Console.WriteLine(average);

      var howManyNumbers = numbers2.Count();
      Console.WriteLine(howManyNumbers);

      var biggerNumbers = numbers2.Where(num => num > 9);
      Console.WriteLine($"\nBigger numbers {string.Join(',', biggerNumbers)}");

      // Select is like Array.map, returns a new collection of IEnumerable
      // Transforming Data

      Console.WriteLine($"\nOrdered {string.Join(',', numbers2)}");

      var biggerNumbers2 = numbers2.Select(num => num + 100);
      Console.WriteLine($"Bigger numbers2 {string.Join(',', biggerNumbers2)}");



      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////
      /// LINQ Element Operations
      var numbers3 = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };
      Console.WriteLine($"Numbers 3  {string.Join(',', numbers3)}");

      var firstNumber = numbers3.First();
      Console.WriteLine($"\nFist number {firstNumber}");

      var lastNumber = numbers3.Last();
      Console.WriteLine($"\nFist number {lastNumber}");

      var fistMatchingNumber = numbers3.Where(num => num > 9).First();
      Console.WriteLine($"\nFist matching number greater than 9 {fistMatchingNumber}");

      var fistMatchingNumber2 = numbers3.First(num => num > 9);
      Console.WriteLine($"\nFist matching number greater than 9 {fistMatchingNumber2}");



      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////
      /// LINQ Quantifiers
      /// The quantifiers return a boolean
      /// All, Any, and Contains
      var numbers4 = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };
      Console.WriteLine($"\nNumbers 4  {string.Join(',', numbers4)}");

      var allNumbers4 = numbers4.All(number => number > 5); // this will return a boolean true or false
      Console.WriteLine($"\nAre all of these numbers greater than 5  {string.Join(',', allNumbers4)}");

      var anyNumbers = numbers4.Any(); // this will return a boolean true or false
      Console.WriteLine($"\nAre there any alements in the container {string.Join(',', anyNumbers)}");

      var anyNumbersLessTha5 = numbers4.Any(num => num < 5); // this will return a boolean true or false
      Console.WriteLine($"\nAre there any alements in the container Less than 5 {string.Join(',', anyNumbersLessTha5)}");

      var contains = numbers4.Contains(7) || numbers4.Contains(3); // this will return a boolean true or false
      Console.WriteLine($"\nContains the number 7 {string.Join(',', contains)}");



      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////
      /// LINQ Set Operations
      var numbers5 = new List<int>() { 8, 3, 3, 11, 11, 23, 9, 9, 3, 2, 7, 300 };
      Console.WriteLine($"\nNumbers 5  {string.Join(',', numbers5)}");

      var badNubmers = new List<int>() { 19, 11, 3, 9 };
      Console.WriteLine($"\nBad numbers  {string.Join(',', badNubmers)}");

      var onlyGoodNumbers = numbers5.Except(badNubmers);
      Console.WriteLine($"\nSet operations numbers {string.Join(',', onlyGoodNumbers)}");

      var uniqueNumbers = numbers5.Distinct();
      Console.WriteLine($"\nDistinct numbers = don't repeat existing values  {string.Join(',', uniqueNumbers)}");

      var numbers6 = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };
      Console.WriteLine($"\nNumbers 6  {string.Join(',', numbers6)}");

      // this will concatenate two sequences
      var firstThreeNumbers = numbers6.Take(3).Concat(numbers5.Skip(5).Take(1));
      Console.WriteLine($"\nTake the first 3 numbers skip 5 number and take 1 {string.Join(',', firstThreeNumbers)}");


      // Check Range of number 
      // Check join  numbers

      var pikachu = new Animal("Electric", 24, 10, "Pikachu");
      var charzar = new Animal("Water, Electric, Rock", 72, 250, "Charizar");
      var bulbasaur = new Animal("Grass, Poison", 12, 450, "Bulbasaur");
      var jigglyPuff = new Animal("Poison, Steel", 9, 5, "JigglyPuff");

      var AnimalList = new List<Animal> { pikachu, charzar, bulbasaur, jigglyPuff };

      // Defered excecution
      //var animalsThatStartWithC = AnimalList.Where(animal => animal.Type.StartsWith('C'));
      //Console.WriteLine($"\n\nAnimals that starty with \"C\" {string.Join(',', animalsThatStartWithC)}");

      //var animalsThatStartWithC = AnimalList.Where(animal => animal.Name.StartsWith('C')).ToList();
      //Console.WriteLine($"\n\nAnimals that starty with \"C\" {string.Join(',', animalsThatStartWithC)}");

      Console.WriteLine("\n\nWHERE \n\n");
      var animalsThatStartWithC = AnimalList.Where(animal => animal.Name.ToLower().StartsWith('c'));
      //Console.WriteLine($"\n\nAnimals that starty with \"C\" { animalsThatStartWithC }\n\n"); // This is not valid

      foreach (var animal in animalsThatStartWithC)
      {
        Console.WriteLine($"{animal.Name}");
      }

      Console.WriteLine("\n\nGROUP BY \n\n");
      // Group collection by a given key (based on a function)
      var groupAnimals = AnimalList.GroupBy(animal => animal.Name.First());

      foreach (var animal2 in groupAnimals)
      {
        //Console.WriteLine(animal2.Key);

        foreach (var animal in animal2)
        {
          Console.WriteLine(animal.Name);
        }
      }


    }
  }
}
