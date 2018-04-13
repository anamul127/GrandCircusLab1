using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Lab1();
        }

        
        public static void Lab1()
        {
            
                List<int> list = new List<int>();
                //holds objects in a specific order
                
                Console.WriteLine("Please print two integer numbers with the same amount of digits.");
                Console.Write("First Number: ");
                string integer1 = Console.ReadLine();
                //user inputs date, date is stored
                
                Console.Write("Second Number: ");
                string integer2 = Console.ReadLine();
                
                try
                {
                    
                    int input1 = Convert.ToInt32(integer1);

                    int input2 = Convert.ToInt32(integer2);
                    //date is converted to integer

                    
                    if (integer1.Length == integer2.Length)
                    //integers from first number should equal integers from second number
                    {
                        
                        var sum = 0;

                        
                        for (int i = 0; i < integer1.Length; i++)
                        {
                             
                            int convert1 = (int)Char.GetNumericValue(integer1[i]);
                            int convert2 = (int)Char.GetNumericValue(integer2[i]);
                            sum = convert1 + convert2;
                            list.Add(sum);
                            //converts string to unicode to integer

                        }

                        
                        int digit1 = list[0];
                        
                        bool statement2 = true;

                         
                        for (int i = 1; i < list.Count; ++i)
                        {
                            
                            if (digit1 != list[i])
                            {
                                statement2 = false;
                            }
                        }
                        //checks if digit one is equal to the rest of the sums in list

                        
                        if (statement2)
                        {
                            Console.WriteLine("True");

                        }
                        else
                        {
                            Console.WriteLine("False");
                        //prints false for invalid entry
                        }
                    }
                    
                    else
                    {
                        Console.WriteLine("Same number of digits not entered");
                    }
                }
                
                catch (Exception)
                {
                    Console.WriteLine("Please enter numbers.");
                //user can only enter numbers
                }
            Console.ReadKey();
        }   
    }
}