using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace session5
{
    internal class demo
    {
        //static Functions (Class Member Function)
        //Object Member Function
        public static void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            
        }

        public static void SumMul(int x,int y,out int sum,out int mul )
        {
            sum = x + y;
            mul = x* y;
        }

        public static int Sumarray(params int[] arr)//passing By value
        {
            int sum = 0;
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];//sum = sum + arr[i]
                }
            }
            return sum;
        }

        public static void DoSomeCode()
        {
            try
            {
                int x, y, z;
                bool flag;
                //x = int.Parse(Console.ReadLine());
                //y = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("pls Enter Number 1");
                    flag=int.TryParse(Console.ReadLine(), out x);
                }while (!flag);
                do
                {
                    Console.WriteLine("pls Enter Number 2");
                    flag = int.TryParse(Console.ReadLine(), out y);
                } while (!flag || y==0);
                z = x / y;
                //null Propagetion Opertor
                int[] numbers = default;// size 3
                if (numbers?.Length>10)
                {
                    numbers[10] = 100;
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void Demo0()
        {
            #region Judged Array
            //// judged array => One D array of Arrays With Differnet Sizes
            //int[][] Numbers = new int[3][];
            //Numbers[0] = new int[] {1,2,3};
            //Numbers[1] = new int[] {4,5};
            //Numbers[2] = new int[] {6};
            ////print
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Numbers[i].Length; j++)
            //        Console.WriteLine($"Numbers[{i}][{j}]:"+Numbers[i][j]);
            //}
            #endregion

            #region passing By Value
            //int a = 4,b = 5;
            //Console.WriteLine($"a="+a);
            //Console.WriteLine($"b=" + b);
            //swap(ref a,ref b);
            //Console.WriteLine($"a=" + a);
            //Console.WriteLine($"b=" + b);
            #endregion

            #region Passing By Out
            //int a = 3, b = 5, sumresult, mulreselt;
            //SumMul(a,b,out sumresult,out mulreselt);
            //Console.WriteLine($"The sum={sumresult}");
            //Console.WriteLine($"The mul={mulreselt}");
            #endregion

            #region Params
            ////int[] Numbers = { 1 , 2 , 3 , 4, 5 };
            ////int Total = Sumarray(Numbers);
            //int Total = Sumarray(1,2,3,4,5);
            //Console.WriteLine("The sum is: "+Total);
            #endregion

            #region boxing vs unboxing
            ////Boxing => casting  From Value Type To Refernce Type
            ////UnBoxing => casting  From Refernce Type
            ////object o1;
            ////o1 = "Omar";
            ////o1 = 3;   //Boxing( Value Type => Refernce Type )

            //int x = 10 ;
            //object obj = x ;  // Boxing [Safe Casting]
            //                 //Parent => Chiled
            //                //Animal => Dog (Dog is an Animal)
            //// ========================

            //object obj2 = "Omar" ;
            //int y = (int)obj2; // Unboxing [Unsafe]
            //                  //Dog = animal ( Animal is Dog)

            //Console.WriteLine(y);

            #endregion

            #region Nullable Oprator ?

            #region Value Type
            //// Value Type => Doesnot  allow Null
            //// Reference Type => Allow Null
            ////-----------------------------------------
            //// c#2 2005
            ////int num = null;
            ////int? num2 = null; // Allow Null or Value
            ////int x = 10;
            ////int? y = x;
            ////-----------------------------------------
            //int? x = 10;// Syntax Suger
            //Nullable<int> num1; // int? num1
            ////int y = x;// invalid
            //float? num2; 
            #endregion
            #region Refence Type
            //Refence Type => Allow Null
            string? Name = "Omar";
            Name = null;
            // Null Forgivness Operator
            //Name = null!;
            #endregion
            #endregion

            #region Null Propagation Oprator
            //int[] Numbers=default;
            //for (int i = 0;/*(Numbers is not null) &&*/ (i < Numbers?.Length);i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //Console.WriteLine(6);
            #endregion

            #region Null Coaleasing Oprator
            //int[] Numbers = default;
            //for (int i = 0;i < Numbers?.Length??0; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //Console.WriteLine(6);
            #endregion

            //try
            //{
            //    DoSomeCode();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //finally
            //{
            //    //close / Delete / Realse / Dellocate / Free Unreachable Resources

            //    // Connection With Detabase
            //}
        }
    }
}
