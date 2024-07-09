// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World!");



// using System;
// namespace Program
// {
//     class Program{
//         public static void Main(string[] args){
//         Console.WriteLine("My name is Asad");
//         }
//     }
// }

List<string> fruits = new List<string>();
fruits.Add("Apple");
fruits.Add("Mango");
fruits.Add("Banana");

Console.WriteLine("Count: " + fruits.Count); 
Console.WriteLine("IndexOf 'Mango': " + fruits.IndexOf("Mango"));
fruits.Remove("Mango");
Console.WriteLine("Count: " + fruits.Count);


















// using System;
// namespace Calculator
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Calculator");
//             Console.WriteLine("1. Addition");
//             Console.WriteLine("2. Subtraction");
//             Console.WriteLine("3. Multiplication");
//             Console.WriteLine("4. Division");

//             Console.Write("Enter your choice (1-4): ");
//             int choice = Convert.ToInt32(Console.ReadLine());

//             Console.Write("Enter first number: ");
//             double num1 = Convert.ToDouble(Console.ReadLine());

//             Console.Write("Enter second number: ");
//             double num2 = Convert.ToDouble(Console.ReadLine());

//             double result = 0;

//             switch (choice)
//             {
//                 case 1:
//                     result = num1 + num2;
//                     break;
//                 case 2:
//                     result = num1 - num2;
//                     break;
//                 case 3:
//                     result = num1 * num2;
//                     break;
//                 case 4:
//                     if (num2 != 0)
//                     {
//                         result = num1 / num2;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Error: Division by zero is not allowed.");
//                         return;
//                     }
//                     break;
//                 default:
//                     Console.WriteLine("Error: Invalid choice.");
//                     return;
//             }

//             Console.WriteLine("Result: " + result);
//         }
//     }
// }