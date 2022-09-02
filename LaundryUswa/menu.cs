using System;

namespace LaundryUswa
{
    public class Menu
    {
        public void menu()
        {
            Console.Clear();
            Console.WriteLine("\t======================================================\n\t\t\tM O T E L   U S W A\t\t\n\t======================================================");
            Console.WriteLine("\tmain menu:");
            Console.Write("\t1. Room Reservation\n\t2. Check-out\n\t3. Exit\n\tHalo, want a reservation or check-out?: ");
            int action = Convert.ToInt32(Console.ReadLine());

            //to reservate room
            if (action == 1)
            {
                Reservation access = new Reservation();
                access.Reservasi();
            }

            //to check-out while checking reservation history
            else if (action == 2)
            {
                Checkout access = new Checkout();
                access.cekout();
            }

            //to exit the app
            else if (action == 3)
            {
                Exit access = new Exit();
                access.exit();
            }

            //if customer input the wrong number
            else
            {
                Console.WriteLine("\n\tWrong input!\n\tInput number between 1-3");
                Console.Write("\tpress any key to continue...");
                Console.ReadKey();
                menu();
            }
        }
    }
}
