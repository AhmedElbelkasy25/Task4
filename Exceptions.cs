namespace Exceptions
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            int total;
            Console.Write("enter total number of the List: ");
            try {
                total = int.Parse(Console.ReadLine());
                int num;
                List<int> lis = new List<int>(total);
                for (int i = 0; i < total; i++)
                {
                    Console.Write("enter number:");
                    num = int.Parse(Console.ReadLine());
                    try
                    {
                        for (int j = 0; j < lis.Count; j++)
                        {
                            if (num == lis[j])
                                throw new Exception();

                        }
                        lis.Add(num);
                    }

                    catch (Exception e) {
                        Console.WriteLine("this number is already excist");
                        i--;
                    }
                }
                for (int i = 0; i < lis.Count; i++)
                {
                    Console.WriteLine(lis[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("/////////////////////////////////////////////////////////////////////");
            Console.WriteLine("this is the end of my program ");
            Console.WriteLine("BYE.... ");
            








            }

        
            
        
    }
}
