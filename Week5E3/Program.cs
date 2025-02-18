using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5E3
{
    internal class Program
    {
        //Use a data structure to store list
        static Dictionary<string, double> webpage = new Dictionary<string, double>(); //global list
       static void Main(string[] args)
            {
                // declaration:

                int selection = 0; // take user input

                Console.WriteLine("Welcome Web Browser Back button application");

                while (true) // repeat forever
                {

                    Console.WriteLine("Input a number to select an option below: \n" +
                        "1: Visit New Page\n" +
                        "2: Go Back\n" +
                        "3: View Browsing History\n" +
                        "4: Exit");

                    selection = Convert.ToInt32(Console.ReadLine());
                    //process menu:

                    switch (selection)
                    {
                        case 1:
                            //process visit page
                            VisitPage();
                            break;
                        case 2:
                            //process go back
                            GoBack();
                            break;
                        case 3:
                            //process view history
                            ViewHistory();
                            break;
                        case 4:
                            //process exit
                            return; // exit from the while loop

                        default:
                            //visit new page
                            Console.WriteLine("Invalid option");
                            break;

                    }
                }


            }
            //method to process new page
            static void VisitPage()
            {
                Console.WriteLine("webpage");

                string page = Console.ReadLine();

                Console.WriteLine("Enter a webpage");

                Console.WriteLine(page + " Page visited successfully!");
            }
            //method to process history
            static void GoBack()
            {
                Console.WriteLine("Going back to");
                string history = Console.ReadLine();
                
                    Console.WriteLine("Going back to:" + history);
               


            }
            


            
            //method to view history
            static void ViewHistory()
            {
                Console.WriteLine("Here is the history");
                
                {
                    Console.WriteLine("Viewing Browsing History:");
                }

            }
        }

    }
    }
}
