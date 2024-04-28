namespace AlphaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("**                   LUISCE PARROQUIN PAULINA N11684763                        **");
            Console.WriteLine("*********************************************************************************");

            //Variables 
            int numInterior, numExterior;
            int n = 0;
            int count = 0;
            int custCount = 0;
            const double CostInterior = 500;
            const double CostExterior = 750;
            double totalInterior, totalExterior, totalRevenue;
            string custName;
            int numLandscape = 0;
            int numSeascape = 0;
            int numAbstract = 0;
            int numOthers = 0;
            string[] customers = new string[100];
            string[] mCodes = new string[100];
            string userInputCodes;
            string stop = "999";
            bool isCodeValid = false;
            string client;
            Console.WriteLine("Please enter the number of interior murals (between 0 and 30):  ");
            numInterior = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of exterior murals (between 0 and 30):  ");
            numExterior = Convert.ToInt32(Console.ReadLine());

            while (n == 0)
            {
                if (numInterior >= 0 && numInterior <= 30 && numExterior >= 0 && numExterior <= 30)  
                {
                    Console.WriteLine("Number of interior mural orders: {0} ", numInterior);
                    Console.WriteLine("Number of exterior mural orders: {0} ", numExterior);
                    totalInterior = numInterior * CostInterior;
                    totalExterior = numExterior * CostExterior;
                    Console.WriteLine("Expected revenue from interior murals: {0} ", totalInterior.ToString("C"));
                    Console.WriteLine("Expected revenue from exterior murals: {0} ", totalExterior.ToString("C"));
                    totalRevenue = totalInterior + totalExterior;
                    Console.WriteLine("Total expected revenue: {0}", totalRevenue.ToString("C"));
                    if (numExterior > numInterior)
                        Console.WriteLine("Exterior murals are becoming more attractive!");
                    else if (numExterior < numInterior)
                        Console.WriteLine("Interior murals are becoming popular!");
                    else
                        Console.WriteLine("Both types are equally preferred!");
                    ++n;
                }

                else
                {
                    Console.WriteLine("Please re-enter a number (between 0 and 30): ");
                    Console.WriteLine("Please enter the number of interior murals (between 0 and 30):  ");
                    numInterior = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the number of exterior murals (between 0 and 30):  ");
                    numExterior = Convert.ToInt32(Console.ReadLine());
                }

            }

           
            Console.WriteLine("Please input the following information regarding the {0} interior mural order(s) ", numInterior);

            

            for (int x = 0; x < numInterior; x++)
            {
                Console.WriteLine("Enter the customer name {0}", x + 1); 
                custName = Console.ReadLine();
                customers[x] = custName;
                Console.WriteLine("Mural options are:");
                Console.WriteLine("L for Landscape");
                Console.WriteLine("S for Seascape");
                Console.WriteLine("A for Abstract");
                Console.WriteLine("O for Others");
                Console.WriteLine("Enter the mural code {0}: ", x + 1); 
                string muralCode = Console.ReadLine();
                if (muralCode == "L" || muralCode == "S" || muralCode == "A" || muralCode == "O")
                {
                    Console.WriteLine("Valid Code");
                    switch (muralCode)
                    {
                        case "L":
                            ++numLandscape;
                            mCodes[x] = muralCode;
                            break;
                        case "S":
                            ++numSeascape;
                            mCodes[x] = muralCode;
                            break;
                        case "A":
                            ++numAbstract;
                            mCodes[x] = muralCode;
                            break;
                        case "O":
                            ++numOthers;
                            mCodes[x] = muralCode;
                            break;
                        default:
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid code. Please enter a valid code");
                    x = x - 1;
                }
            }
            Console.WriteLine("Number of customers ordering Lanscape murals: " + numLandscape);
            Console.WriteLine("Number of customers ordering Seascape murals: " + numSeascape);
            Console.WriteLine("Number of customers ordering Abstract murals: " + numAbstract);
            Console.WriteLine("Number of customers ordering Others murals: " + numOthers);
                        
            do
            {
                Console.WriteLine("Mural options are: L for Landscape     S for Seascape       A for Abstract      O for Others ");
                Console.WriteLine("Please enter a mural code to display customers (L, S, A, O) or type '999' to quit: ");
                userInputCodes = Console.ReadLine();

                { for (int i = 0; i < mCodes.Length; i++)

                        if (mCodes[i] == userInputCodes)
                        {
                            isCodeValid = true;
                            client = customers[i];
                            Console.WriteLine(client);
                        }
                        
                }

            } while (userInputCodes != "999");
        }









    }
}   
            










        


