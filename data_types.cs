namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xx = "hammed";
            string xxx = "ahmed";

            //regular concatination
            string y = xx + " " + xxx;
            
            // string interpolation
            string z = $"{xx} {xxx}";

            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();

            //var 
            /*  var f = 0f; // it's a float numbeer
              var d = 5d; // double number 
              var m = 0m;
              var u = 0u;
              var l = 0l ;
              var ul= 0ul;
              Console.WriteLine(f);
              Console.WriteLine(d);
              Console.WriteLine(m);
              Console.WriteLine(u);
              Console.WriteLine(l);
              Console.WriteLine(ul);
            */
            dynamic d = 10;
            d = "aaaa";
            Console.WriteLine(d);


        }
    }
}