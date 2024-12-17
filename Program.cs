using System.Diagnostics.CodeAnalysis;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace session5
{
    internal class Program
    {

        #region 01 The Method
        static void ValueTypeParametersByValue(int x)
        {
            x = 100;
        }
        static void ValueTypeParametersByReference(ref int x)
        {
            x = 100;
        }
        #endregion
        #region 02 The Method
        static void ReferenceTypeParametersByValue(int[] x)
        {
            x[0] = 100;
        }
        static void ReferenceTypeParametersByReference(ref int[] x)
        {
            x[0] = 100;
        }
        #endregion
        #region 03 The Method
        static void SumAndSub(int num1,int num2,out int sum,out int sub)
        {
            sum = num1 + num2;
            sub = num1 - num2;
        }
        #endregion
        #region 04 The Method
        static int sumOfGivenNumber(string x)
        {
            int sum = 0;
            for (int i = 0;i < x.Length;i++)
            {
                sum += int.Parse(x[i].ToString());
            }
            return sum;
        }
        #endregion
        #region 05 The Method
        static bool IsPrime(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false; 
            }
            return true;
        }
        #endregion
        #region 06 The Method
        static void MinMaxArray(int[] arr,out int min,out int max)
        {
            min = arr.Min();
            max = arr.Max();
            
        }
        #endregion
        #region 07 The Method
        //static int factorial(int x)
        //{
        //    int sum = 1;
        //    for (int i = x;i > 0;i--)
        //    {
        //        sum *= i;
        //    }
        //    return sum ;
        //}
        #endregion
        #region 08 The Method
        static string ChangeChar(string str , char pos , char replc)
        {
            return str.Replace(pos, replc);
        }
        #endregion
        
        static void Main(string[] args)
        {
            demo.Demo0();

            //Assignment 4
            //Functions
            #region 01
            ////Explain the difference between passing (Value type parameters)
            ////by value and by reference
            ////then write a suitable c# example?
            /////////////////////////////////////////////////
            ////1. Passing by Value
            ////1- copy of the value is passed to the method.
            ////2- Any changes made to the parameter inside the method
            ////do not affect the original variable.

            ////2. Passing by Reference
            ////1- Changes made to the parameter inside the method affect the original variable.

            ////ex
            //int x = 0;
            //Console.WriteLine("before call: "+ x);
            //ValueTypeParametersByValue(x);
            //Console.WriteLine("After call: " + x);

            //Console.WriteLine("Value Type Parameters By Reference");

            //int y = 0;
            //Console.WriteLine("before call: " + y);
            //ValueTypeParametersByReference(ref y);
            //Console.WriteLine("After call: " + y);
            #endregion

            #region 02
            ////Explain the difference between passing (Reference type parameters)
            ////by value and by reference then write a suitable c# example?

            /////////////////////////////////////////////////
            ////1. Passing by Value
            ////1- A copy of the reference (not the object itself) is passed to the method.
            ////2- The method can modify the object the reference points to, but it cannot change
            ////the reference to point to a new object.

            ////2. Passing by Reference
            ////1- The reference itself is passed to the method, not just a copy of the reference.
            ////2- The method can modify both the object's properties and reassign the reference to a new object.

            ////ex
            //int[] x = { 0,1 };
            //Console.WriteLine("before call: " + x[0]);
            //ReferenceTypeParametersByValue(x);
            //Console.WriteLine("After call: " + x[0]);

            //Console.WriteLine("Reference Type Parameters By Reference");

            //int[] y = { 0, 1 };
            //Console.WriteLine("before call: " + y[0]);
            //ReferenceTypeParametersByReference(ref y);
            //Console.WriteLine("After call: " + y[0]);
            #endregion

            #region 03
            //Console.WriteLine("Enter 2 numbers");
            //int x= int.Parse(Console.ReadLine());
            //int y= int.Parse(Console.ReadLine());
            //int sum, sub;
            //SumAndSub(x, y, out sum, out sub);
            //Console.WriteLine($"summation is: {sum} , subtractin is: {sub}");
            #endregion

            #region 04
            //Console.WriteLine("enter number:");
            //string num = Console.ReadLine();
            //int sum = sumOfGivenNumber(num);
            //Console.WriteLine($"The sum of the digits of the number {num} is: {sum}");
            #endregion

            #region 05
            //Console.WriteLine("Enter number");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsPrime(num));
            #endregion

            #region 06
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int min ,max ;
            //MinMaxArray(arr,out min,out max);
            //Console.WriteLine($"The min is: {min} , The max is: {max}");

            #endregion

            #region 07
            //Console.WriteLine("Enter number to get factorial:");
            //int input = int.Parse(Console.ReadLine());
            //int sum = factorial(input);
            //Console.WriteLine($"The factorial for number {input} is {sum}");
            #endregion

            #region 08
            //Console.WriteLine("Enter string: ");
            //string input = Console.ReadLine();
            //Console.WriteLine("Enter char to delete: ");
            //char cha1 = char.Parse(Console.ReadLine());
            //Console.WriteLine("Enter char to replac: ");
            //char cha2 = char.Parse(Console.ReadLine());

            //Console.WriteLine(ChangeChar(input,cha1,cha2));

            #endregion
        }
    }
}
