using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // string s = null;
            //  s = s ?? "issam";
            //  s.ToUpper();  null refrence exception
            //Console.WriteLine(s?.ToUpper());
            // var x= s is null ? null : s.ToUpper();
            // Console.WriteLine(s);
            // var i = "";
            // i.ToUpper();
            //  Console.WriteLine(i);

            //expression statement 
            //1.change state :
            // var name = "mai";
            // name = name + " azaaa";
            //  Console.WriteLine(name);

            //2.call something that changes the state 
            //  name = name.ToUpper();
            //  Console.WriteLine(name);

            //switch 
            /*  var amountJod = 100;
              var currentType = "usd";
              double output = 0;

              var jodTousd = 1.14d;
              var jodToeur = 1.19d;
              var jodTocad = 1.22d;

              switch (currentType)
              {
                  case ("usd"):
                      output = amountJod * jodTousd;
                      Console.WriteLine($"{amountJod} jod = {output} usd");
                      break;
                  case ("eur"):
                      output = amountJod * jodToeur;
                      Console.WriteLine($"{amountJod} jod = {output} eur");
                      break;
                  case ("cad"):
                      output = amountJod * jodTocad;
                      Console.WriteLine($"{amountJod} jod ={output}cad");
                      break;
                      default:
                      Console.WriteLine("0");
                      break;

              }*/

            /*    var x = 3;
                switch (x)
                    //more than one condition excute the same value
                {
                    case 1:
                    case 3:
                    case 5:
                        Console.WriteLine("odd");
                        break;
                    case 2:
                    case 4:
                    case 6:
                        Console.WriteLine("even");
                        break;
                }*/

            /* 
             * object x = 3;
              switch (x)
              {
                  case int y:
                      Console.WriteLine($"it's a int , sqr of {y}={y * y}");
                      break;
                  case string y:
                      Console.WriteLine($"it's a string ,the capatalizationof{y} = {y.ToUpper()}");
                        break;
              }
            */

            /*
             * bool isVip = true;
              switch (isVip)
              {
                  case bool i when i == true:
                      Console.WriteLine("yeeees");
                  break;
                  case bool i:
                      Console.WriteLine("nooooo");
                      break;
              } 
              */

            
             var cardno = 13;

             string cardName = cardno
                switch
             {
                 1 => "ace",
                 2 => "king",
                 13 => "queen",
                 _ => cardno.ToString()

             };
             Console.WriteLine(cardName);
            

            //Iteration
            //ex:febonacci  (0,1,1,2,3,5,8,13,21,34)
            /*
             * int perv = 0, current = 1;
             for (int counter = 0 ; counter < 10; counter++)
             {
                 Console.Write(perv + " ");
                 int newFib = perv + current;
                 perv = current;
                 current = newFib;
             }
            */

            //2.foreach
            /*
             * var arr = new int[] {1,2,3 };
             foreach(var n in arr )
             {
                 Console.Write(n + " ");
             }

             for(int i =0;i<arr.Length;i++)
             {
                 Console.Write(arr[i]+" ");
             }
            */


            /*
            var i = 0;
            while (i < 10)
            {
                if (i>5)
                { break; }
                Console.Write(i + " ");
                i++;
            }
            */
            Console.ReadKey();
           

        }
    }
}
