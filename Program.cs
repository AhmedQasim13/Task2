using System.Collections;
using System.Linq;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
          {
            List<int> mylist = new List<int>();
            int check=0;
            char charselection = ' ';
            //
            do
            {
                Console.WriteLine("\t \t \t \t \t \t \t \t  [***The menu is ***] \n");
                Console.WriteLine("\t \t \t \t \t \t \t [P]>> click P for Print numbers.");
                Console.WriteLine("\t \t \t \t \t \t \t [A]>> click A for Add numbers.");
                Console.WriteLine("\t \t \t \t \t \t \t [M]>> click M for Display mean of numbers.");
                Console.WriteLine("\t \t \t \t \t \t \t [S]>> click S for Smallest numbers.");
                Console.WriteLine("\t \t \t \t \t \t \t [L]>> click L for Largest numbers.");
                Console.WriteLine("\t \t \t \t \t \t \t [F]>> click F for Find numbers.");
                Console.WriteLine("\t \t \t \t \t \t \t [C]>> click C for Clear the whole list.");
                Console.WriteLine("\t \t \t \t \t \t \t [Q]>> click Q for quit .");
                charselection = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                switch (charselection)
                {
                    case 'P':
                        if (mylist.Count == 0)
                            Console.WriteLine($"the list is empty [{string.Join(" ", mylist)}]");  //https://stackoverflow.com/questions/10347455/string-format-with-string-join
                        else
                            Console.WriteLine($"[{string.Join(" ", mylist)}]");                     //https://stackoverflow.com/questions/10347455/string-format-with-string-join
                        break;
                    case 'A':
                        Console.WriteLine($"Please Add numbers:");
                        check = Convert.ToInt32(Console.ReadLine());
                        if (mylist.Contains(check) == false)
                        {
                            mylist.Add(check);
                            Console.WriteLine($"the value {check} added successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"Number {check} is already in the list.");
                        }
                        break;
                    case 'M':
                        for (int i = 0; i < mylist.Count; i++)
                        {
                            check += mylist[i];
                        }
                        Console.WriteLine($"the Mean of the list is {check / mylist.Count}");
                        break;
                    case 'S':
                        for (int i = 0; i < mylist.Count; i++)
                        {
                            for (int j = i + 1; j < mylist.Count; j++)
                            {
                                if (mylist[i] < mylist[j])
                                {
                                    check = mylist[i];
                                    mylist[i] = mylist[j];
                                    mylist[j] = check;
                                }
                            }
                        }
                        Console.WriteLine($"The Smallest number is {mylist[^1]}");
                        break;
                    case 'L':
                        for (int i = 0; i < mylist.Count; i++)
                        {
                            for (int j = i + 1; j < mylist.Count; j++)
                            {
                                if (mylist[i] > mylist[j])
                                {
                                    check = mylist[i];
                                    mylist[i] = mylist[j];
                                    mylist[j] = check;
                                }
                            }
                        }
                        Console.WriteLine($"The Smallest number is {mylist[^1]}");
                        break;
                    case 'F':
                        Console.WriteLine("please enter the number you want to search ?");
                        check = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i <mylist.Count; i++)
                        {
                            if (mylist[i] == check)
                            {
                                Console.WriteLine($"the number{check} exists, and the index is {i}");
                            }
                        }
                        break;
                    case 'C':
                        mylist.Clear();
                        Console.WriteLine("The whole list is cleared (-_-).");
                        break;
                    case 'Q':
                        Console.WriteLine("The program ended, Goodbye(^-^).");
                        break;
                    default:
                        Console.WriteLine("character not defind (^0^).");
                        break;
                }
            } while (charselection != 'Q');
        }
    }
}
