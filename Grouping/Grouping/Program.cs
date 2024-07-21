namespace Grouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
            

        }
        public static void Menu()
        {
            
            string header = "==========================\n     Qualifying Stage\n==========================\n";
            
            while (true)
            {
                int select;
                Console.WriteLine(header);
                Console.WriteLine("1] Start The Stage\n\n2] Exit\n");
                while (true)
                {
                    try
                    {
                        select = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unknown Choice");
                        continue;
                    }
                    if (select > 0 && select < 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Unknown Choice");
                        continue;
                    }
                }
                if (select == 1)
                {
                    Console.Clear();
                    Console.WriteLine(header);
                    


                    int numberOfUsers;
                    while (true)
                    {
                        Console.Write("Enter Number Of Users : ");
                        try
                        {
                            numberOfUsers = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Invalid Input");
                            continue;
                        }
                        if (numberOfUsers > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please Enter Number Greater Than Zero");
                            continue;
                        }
                    }


                    
                    string[] arr = new string[numberOfUsers];
                    Console.Clear();
                    Console.WriteLine(header);
                    Console.WriteLine("\nEnter Names Of Users \n-----------------------\n");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"User ({i+1}) : ");
                        arr[i] = Console.ReadLine();
                    }
                    Console.Clear();
                    Console.WriteLine(header);
                    Stage s = new Stage(numberOfUsers);
                    s.DisplayMatchesCenimatic(arr);
                    Console.WriteLine("====================================\n< Click Enter To Back >");
                    string enter = Console.ReadLine();
                    Console.Clear();
                }
                else break;

            }
            
        }
    }
}
