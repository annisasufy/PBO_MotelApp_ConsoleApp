using System;
using System.IO;

namespace LaundryUswa
{
    internal class Reservation
    {
        string name;
        string number;
        string room;
        string date;
        string filename;
        string content;
        public void Reservasi()
        {
            Console.Clear();
            Console.WriteLine("\t======================================================\n\t\t\tM O T E L   U S W A\t\t\n\t======================================================");
            Console.WriteLine("\tmain menu > Room Reservation:");

            //customer fill out the form
            Console.Write("\tName\t\t: ");
            name = Console.ReadLine();
            Console.Write("\tTelp Number\t: ");
            number = Console.ReadLine();
            Console.Write("\tRoom Number\t: ");
            room = Console.ReadLine();
            Console.Write("\tDate Reservation (DD/MM/YYYY)\t: ");
            date = Console.ReadLine();

            //append the customer data to file .txt
            filename = "../../CostumerData.txt";
            content = name + "\t" + number + "\troom " + room + "\t" + date + "\n";
            File.AppendAllText(filename, content);

            Console.WriteLine("\t" + name + " has successfully reservate the room " + room);

            //navigate to menu
            Menu instance = new Menu();
            instance.menu();
        }
    }
}
