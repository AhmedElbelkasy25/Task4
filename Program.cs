namespace Exceptions2
{
    internal class Program
    {
        public static void Text()
        {
            string inpString;
            Console.WriteLine("enter string");
            inpString= Console.ReadLine().ToLower();
            try
            {
                if (!inpString.Contains('a') && !inpString.Contains('e') && !inpString.Contains('i') &&
                    !inpString.Contains('o') && !inpString.Contains('u'))
                {
                    throw new Exception("Your string doesn't conatin vowels");
                }else
                {
                    Console.WriteLine($"your string is {inpString}");
                }

            }

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            
            }

            finally {
                Console.WriteLine();
                Console.WriteLine("////////////////////////////////////////////");
                Console.WriteLine("End of my program");
            }
            
            
        }
        static void Main(string[] args)
        {
            Text();
        }
    }
}
