//hi this is alex playing with stuff and matt

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bStay = true;
            int iUserInput1;
            int iUserInput2;
            string sUserInput3;
            string sDeleteString;
            string sSearchString;
            //this may work maybe


            Stack<string> myStack = new Stack<string>();
            Stack<string> myHoldStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();
            Queue<string> myHoldQueue = new Queue<string>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();


            while (bStay)
            {
                //display the main menu
                Console.WriteLine("1. Stack\n2. Queue\n3. Dictionary\n4. Exit");
                iUserInput1 = Convert.ToInt32(Console.ReadLine());
                //when the user chose Stack
                if (iUserInput1 == 1)
                {
                    Console.WriteLine(
                        "\n\n1. Add one time to Stack\n" +
                        "2. Add Huge List of Items to Stack\n" +
                        "3. Display Stack\n" +
                        "4. Delete from Stack\n" +
                        "5. Clear Stack\n" +
                        "6. Search Stack\n" +
                        "7. Return to Main Menu");

                    iUserInput2 = Convert.ToInt32(Console.ReadLine());

                    if (iUserInput2 == 1)
                    {
                        Console.WriteLine("Enter a string: ");
                        sUserInput3 = Console.ReadLine();
                        myStack.Push(sUserInput3);

                    }
                    else if (iUserInput2 == 2)
                    {
                        myStack.Clear();
                        for (int iCount = 1; iCount < 2001; iCount++)
                        {
                            myStack.Push("New Entry " + iCount);
                        }
                    }
                    else if (iUserInput2 == 3)
                    {
                        if (myStack.Count == 0)
                        {
                            Console.WriteLine("The data structure is empty\n\n");
                        }
                        else
                        {
                            foreach (string StackItem in myStack)
                            {
                                Console.WriteLine(StackItem);
                            }
                        }
                    }
                    else if (iUserInput2 == 4)
                    {
                        Console.WriteLine("Enter a string to delete from the data structure: ");
                        sDeleteString = Console.ReadLine();

                        if (myStack.Contains(sDeleteString))
                        {

                            while (myStack.Count > 0)
                            {
                                if (myStack.Peek() == sDeleteString)
                                {
                                    myStack.Pop();
                                }
                                else
                                {
                                    myHoldStack.Push(myStack.Pop());
                                }
                            }

                            for (int iCount = 0; myHoldStack.Count > 0; iCount++)
                            {
                                myStack.Push(myHoldStack.Pop());
                            }

                            Console.WriteLine("String deleted successfully\n\n");
                        }
                        else
                        {
                            Console.WriteLine("String not found in the data structure\n\n");
                        }
                    }
                    else if (iUserInput2 == 5)
                    {
                        myStack.Clear();
                        Console.WriteLine("Data structure is cleared successfully");
                    }
                    else if (iUserInput2 == 6)
                    {
                        Console.WriteLine("Enter a string to search for: ");
                        sSearchString = Console.ReadLine();

                        sw.Start();
                        myStack.Contains(sSearchString);
                        sw.Stop();

                        if (myStack.Contains(sSearchString))
                        {
                            Console.WriteLine("String found in the data structure\n" + "Elapsed time: " + sw.Elapsed);
                        }
                        else
                        {
                            Console.WriteLine("String not found in the data structure\n" + "Elapsed time: " + sw.Elapsed);
                        }

                    }
                    else if (iUserInput2 == 7)
                    {
                        //do nothing so it loops back to the main menu
                    }

                }//when the user chose Queue
                else if (iUserInput1 == 2)
                {
                    Console.WriteLine(
                        "\n\n1. Add one time to Queue\n" +
                        "2. Add Huge List of Items to Queue\n" +
                        "3. Display Queue\n" +
                        "4. Delete from Queue\n" +
                        "5. Clear Queue\n" +
                        "6. Search Queue\n" +
                        "7. Return to Main Menu");

                    iUserInput2 = Convert.ToInt32(Console.ReadLine());

                    if (iUserInput2 == 1)
                    {
                        Console.WriteLine("Enter a string: ");
                        sUserInput3 = Console.ReadLine();
                        myQueue.Enqueue(sUserInput3);
                    }
                    else if (iUserInput2 == 2)
                    {
                        myQueue.Clear();
                        for (int iCount = 1; iCount < 2001; iCount++)
                        {
                            myQueue.Enqueue("New Entry " + iCount);
                        }
                    }
                    else if (iUserInput2 == 3)
                    {
                        if (myQueue.Count == 0)
                        {
                            Console.WriteLine("The data structure is empty\n\n");
                        }
                        else
                        {
                            foreach (string QueueItem in myQueue)
                            {
                                Console.WriteLine(QueueItem);
                            }
                        }
                    }
                    else if (iUserInput2 == 4)
                    {
                        Console.WriteLine("Enter a string to delete from the data structure: ");
                        sDeleteString = Console.ReadLine();

                        if (myQueue.Contains(sDeleteString))
                        {
                            while (myQueue.Count > 0)
                            {
                                if (myQueue.Peek() == sDeleteString)
                                {
                                    myQueue.Dequeue();
                                }
                                else
                                {
                                    myHoldQueue.Enqueue(myQueue.Dequeue());
                                }
                            }

                            for (int iCount = 0; myHoldQueue.Count > 0; iCount++)
                            {
                                myQueue.Enqueue(myHoldQueue.Dequeue());
                            }

                            Console.WriteLine("String deleted successfully\n\n");
                        }
                        else
                        {
                            Console.WriteLine("String not found in the data structure\n\n");
                        }

                    }
                    else if (iUserInput2 == 5)
                    {
                        myQueue.Clear();
                        Console.WriteLine("Data structure is cleared successfully");
                    }
                    else if (iUserInput2 == 6)
                    {
                        Console.WriteLine("Enter a string to search for: ");
                        sSearchString = Console.ReadLine();

                        sw.Start();
                        myQueue.Contains(sSearchString);
                        sw.Stop();

                        if (myQueue.Contains(sSearchString))
                        {
                            Console.WriteLine("String found in the data structure\n" + "Elapsed time: " + sw.Elapsed);
                        }
                        else
                        {
                            Console.WriteLine("String not found in the data structure\n" + "Elapsed time: " + sw.Elapsed);
                        }

                    }
                    else if (iUserInput2 == 7)
                    {
                        //do nothing so it loops back to the main menu
                    }

                }//when the user chose Dictionary
                else if (iUserInput1 == 3)
                {
                    Console.WriteLine(
                        "\n\n1. Add one item to Dictionary\n" +
                        "2. Add Huge List of Items to Dictionary\n" +
                        "3. Display Dictionary\n" +
                        "4. Delete from Dictionary\n" +
                        "5. Clear Dictionary\n" +
                        "6. Search Dictionary\n" +
                        "7. Return to Main Menu");

                    iUserInput2 = Convert.ToInt32(Console.ReadLine());

                    if (iUserInput2 == 1)
                    {
                        Console.WriteLine("Enter a string: ");
                        sUserInput3 = Console.ReadLine();
                        myDictionary.Add(sUserInput3, myDictionary.Count);
                    }
                    else if (iUserInput2 == 2)
                    {
                        myDictionary.Clear();
                        for (int iCount = 1; iCount < 2001; iCount++)
                        {
                            myDictionary.Add("New Entry " + iCount, (myDictionary.Count + 1));
                        }

                    }
                    else if (iUserInput2 == 3)
                    {
                        if (myDictionary.Count == 0)
                        {
                            Console.WriteLine("The data structure is empty\n\n");
                        }
                        else
                        {
                            foreach (KeyValuePair<string, int> DictItem in myDictionary)
                            {
                                Console.WriteLine("Key: " + DictItem.Key + " Value: " + DictItem.Value);
                            }
                        }
                    }
                    else if (iUserInput2 == 4)
                    {
                        Console.WriteLine("Enter a string to delete from the data structure: ");
                        sDeleteString = Console.ReadLine();

                        if (myDictionary.ContainsKey(sDeleteString))
                        {
                            myDictionary.Remove(sDeleteString);

                            Console.WriteLine("String deleted successfully\n\n");
                        }
                        else
                        {
                            Console.WriteLine("String not found in the data structure\n\n");
                        }
                    }

                    else if (iUserInput2 == 5)
                    {
                        myDictionary.Clear();
                        Console.WriteLine("Data structure is cleared successfully");
                    }
                    else if (iUserInput2 == 6)
                    {
                        Console.WriteLine("Enter a string to search for: ");
                        sSearchString = Console.ReadLine();

                        sw.Start();
                        myDictionary.ContainsKey(sSearchString);
                        sw.Stop();

                        if (myDictionary.ContainsKey(sSearchString))
                        {
                            Console.WriteLine("String found in the data structure\n" + "Elapsed time: " + sw.Elapsed);
                        }
                        else
                        {
                            Console.WriteLine("String not found in the data structure\n" + "Elapsed time: " + sw.Elapsed);
                        }
                    }
                    else if (iUserInput2 == 7)
                    {
                        //do nothing so it loops back to the main menu
                    }


                }//When the user chose Exit
                else if (iUserInput1 == 4)
                {
                    Console.WriteLine("Good bye");
                    //break out of the while loop and end the program
                    bStay = false;
                }

            }


            Console.ReadLine();
        }
    }
}
