/*
*********************************
 Script made by: Erick B. Gómez
 https://github.com/ErickBGomez
*********************************
*/

using System;

namespace DoublyLinkedListEmail
{
    class Program
    {
        public static string userEmailAddress = "localUser@email.com";

        static void Main(string[] args)
        {
            bool exit = false;
            int option;

            DoublyLinkedList inbox = new DoublyLinkedList();
            DoublyLinkedList sentMails = new DoublyLinkedList();

            inbox.ComposeMailAlt("test@gmail.com", "Important message", "");
            inbox.ComposeMailAlt("support@fictionaldomain.com", "System support", "");
            inbox.ComposeMailAlt("no-reply@thisemail.com", "A happy greetings", "");

            // Startup interface
            do
            {
                Console.Clear();

                // Title

                Console.WriteLine("+-------------+");
                Console.WriteLine("      Home     ");
                Console.WriteLine("+-------------+\n");

                Console.WriteLine("Welcome to DLL Email");
                Console.WriteLine("Logged in as: " + userEmailAddress);
                Console.WriteLine("\nSelect one option:\n[1] Check Inbox\n[2] Check Sent Mails\n[3] Compose a new mail\n[0] Exit");

                // Read user's input
                option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    // Show inbox
                    case 1:
                        inbox.ShowMails();
                        break;

                    // Show sent mails
                    case 2:
                        sentMails.ShowMails();
                        break;

                    // Compose a new mail
                    case 3:
                        sentMails.ComposeMail();
                        break;

                    // Exit
                    case 0:
                        exit = true;
                        break;
                }

            }
            while (!exit);

            Console.WriteLine("\nExiting the system, thanks for prefering us\nMade with <3 by Erick B. Gómez");
            Console.ReadKey();
        }
    }
}
