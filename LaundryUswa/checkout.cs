using MotelUswaApp;
using System;
using System.IO;
using System.Linq;

namespace LaundryUswa
{
    internal class Checkout : Reservation
    {
        string keyword;
        string filename;
        string n = "";
        public void cekout()
        {
            Console.Clear();
            Console.WriteLine("\t======================================================\n\t\t\tM O T E L   U S W A\t\t\n\t======================================================");
            Console.WriteLine("\tmain menu > Check-out:");
            Console.Write("\tEnter name: ");
            keyword = Console.ReadLine();

            //search for the data reservation history
            filename = "../../CostumerData.txt";
            foreach (var match in File.ReadLines(filename)
                                       .Select((text, index) => new { text, lineNumber = index + 1 })
                                       .Where(x => x.text.Contains(keyword)))
            {
                Console.WriteLine("\tReservation History:\n\t\t" + "{0}: {1}", match.lineNumber, match.text);
                Console.WriteLine("\t\t" + keyword + " has successfully checked-out\n\t\tThank you for your visit");
                //if there are no line found will navigate to menu
            }
            Console.ReadLine();

            //navigate to menu
            Menu instance = new Menu();
            instance.menu();
        }
    }
}
