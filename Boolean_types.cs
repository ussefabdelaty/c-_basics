namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* bool isvip = true;

             var x = 10;
             var y = 10;
            */
            // Console.WriteLine(y==x); //y is equal x? =>true ==it's called performance 

            //expression                          
            //var z = x==y;
            // Console.WriteLine(z); == it's called readAbility

             //comparison operator < , > , ==

              var total = 1000;
              var vipThreshold = 900;
              var isVip = total >= vipThreshold;
              Console.WriteLine(isVip);
           


            /*
             //negation 
             var isVip =! true;
             Console.WriteLine(isVip);
            */

            //conditional operator 

            //logical and &&

            //logical or ||

            //logical xor ^

/* 
             // & | Vs. && ||
               bool value = true | check();
              Console.WriteLine(value);


               Console.ReadKey();   
           }
           static bool check()
           {
               Console.WriteLine("checking....");
               return true;
           }
*/

          /*  //== comparison

            //compare the value type 
            var x = 10;
            var y = 10;
            var z = x==y;   
            Console.WriteLine(z);
           

            //compare the refrences type 
            var a = "hello";
            var b = "hello";
            var c = a == b;
            Console.WriteLine(c);*/

            //ternary operator 
      /*    var total = 900;
            var vipThreshold = 1000;
            var isVip = total  == vipThreshold ? "cold" :"perfect"  ;
            Console.WriteLine(isVip);
         
            Console.ReadKey();*/
        }
    }
}