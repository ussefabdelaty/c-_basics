namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // implicit conversion 
            /*
                         * int x = 100;
                         long y = x;
                         Console.Write(y);
            */

            /*            long y = 100;
                        int i = (int)y;
                       Console.Write(i);
            */
            //explicit 
            //unboxing 
         /*  
          *  object obj = 10;
             int x = (int)obj;
             Console.WriteLine(obj);
         */
            /* long i = 200;
                         if(i<=Int32.MaxValue)
                         {
                             int x = (int)i;
                 Console.WriteLine(x);
                         }
            */

            //object obj = 10;

            //convert from string to intger
            /*           //type.Parse
                        string myValue = "1000";
                        int number = int.Parse(myValue);
                        Console.Write(number);

             //type.TryParse
            string myValue = "999999999999";
            if (int.TryParse(myValue,out int numbeer ))
            {
                Console.WriteLine(numbeer);
            }
            else
            {
                Console.WriteLine("unvalid number!");
            }



            */
            
                        string myValue = "55";
                        var i = Convert.ToByte(myValue);
                        Console.WriteLine(i);       

            

            //bit_Convert
            /*
                        var number = 155;
                        var bytes = BitConverter.GetBytes(number);
                        foreach (var b in bytes)
                        {
                            var binary = Convert.ToString(b, 2).PadLeft(8,'0');

                            Console.WriteLine(binary);
                        }
           */
            //convert from string to intger 
            
                        Console.WriteLine("please enter the nme to convert !");
                        var name = Console.ReadLine();

                        char[] letters = name.ToCharArray();
                        foreach (var l in letters)
                        {
                            int ascii = Convert.ToInt32(l);
                            var output = $"'{l}'=> ASCii : {ascii},binary:{Convert.ToString(ascii, 2).PadLeft(8, '0')},hexadecimal: {ascii:x}";
                            Console.WriteLine(output);
                        }

            //convert from hexadicimal to string 
            /*
                        string[] hexvalue = { "49", "73", "73", "61", "6d" };
                        foreach (var hex in hexvalue)
                        {
                            int value = Convert.ToInt32(hex, 16);
                            var stringValue = Char.ConvertFromUtf32(value);//1
                            Console.WriteLine(stringValue);
                            var ch = (char)value;//2
                            Console.WriteLine(ch);
                        }
            */
            //convert from hexadicimal to intger 
            /*    var hex = "8E2";
                int number = Int32.Parse(hex ,System.Globalization.NumberStyles.HexNumber);
                Console.WriteLine(number);  */
            Console.ReadKey();

        }
    }
}