using System;

namespace TestTypeConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i1 = 1234;
            //Implicit conversion
            float f1 = i1;
            Console.WriteLine(f1);

            int i2 = 500;
            //Explicit conversion. Loss of value cause integer value to big.
            byte b = (byte)i2;
            Console.WriteLine(b);

            string s1 = "1234";

            try
            {
                //Conversion of incompatible types
                int i3 = Convert.ToInt32(s1);
                Console.WriteLine(i3);

                string str = "true";
                bool @bool = Convert.ToBoolean(str);
                Console.WriteLine(@bool);

                //Conversion fails. Throws an OverflowException.
                byte b2 = Convert.ToByte(s1);
                Console.WriteLine("Conversion from string to byte {0}", b2);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Not able to convert the value {0} to a byte. Value to big", s1);
            }
        }
    }
}
