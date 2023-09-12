using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //single dimenstion array 
            //declaration 
            /* string[] friends = new string[5];
             //accessing 
             friends[0] = "ali";
             friends[1] = "mai";
             friends[2] = "allaam";
             friends[3] = "ramii";
             friends[4] = "samii";*/

            //anotheer way to define the array 
            // string[] friends = { "ali", "ahmed", "loai", "ramdan" };

            //friends.Print();

            //multi dimenstional array (1:rectangle array ,2:jagged array )
            //1ex:
            /*  int[,] sudoko = {
             {1,2,3,4,8,7,3,7},
             {5,4,9,8,8,7,2,1 },
             {1,2,3,4,5,6,7,8 }

             };
             */

            //2ex
            /*var jagged = new int[][]
            {
               new int []{1,2},
               new int []{3,4,5},
               new int []{7},
           };
            */

            string[] friends = { "ali", "ahmed", "loai", "ramdan" ,"mohamed","benyamin"};
           // var slice = ..0;
            var first = friends[2..3]; 
           
            first.Print();

        }
    }
   public static class extensions
    {
        public static void Print<T>(this T[] source)
        {
            if (!source.Any())
            {
                Console.WriteLine("{}");
                return;
            }
           Console.WriteLine("{ ");
            for (var i = 0; i < source.Length; i++)
            {
                Console.WriteLine($" { source[i] } ");
                Console.WriteLine(i < source.Length - 1 ? ",":"");
                
            }
           Console.WriteLine(" }");
        }
    }
}