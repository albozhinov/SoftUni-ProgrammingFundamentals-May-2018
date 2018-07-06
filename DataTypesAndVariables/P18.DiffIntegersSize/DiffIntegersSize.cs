using System;


namespace P18.DiffIntegersSize
{
    class DiffIntegersSize
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
                        
            var text = "";
            bool isFit = false;

            try
            {
                sbyte num = sbyte.Parse(number);
                text += "\n* sbyte";
                isFit = true;
            }
            catch (Exception)
            {              
                
            }
            try
            {
                var num = byte.Parse(number);
                text += "\n* byte";
                isFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                var num = short.Parse(number);
                text += "\n* short";
                isFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                var num = ushort.Parse(number);
                text += "\n* ushort";
                isFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                var num = int.Parse(number);
                text += "\n* int";
                isFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                var num = uint.Parse(number);
                text += "\n* uint";
                isFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                var num = long.Parse(number);
                text += "\n* long";
                isFit = true;
            }
            catch (Exception)
            {

            }

            if (isFit)
            {
                Console.WriteLine($"{number} can fit in:" + text);
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }

        }
    }
}
