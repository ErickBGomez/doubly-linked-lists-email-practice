/*
*********************************
 Script made by: Erick B. Gómez
 https://github.com/ErickBGomez
*********************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListEmail
{
    class DoublyLinkedList
    {
        private Node head;
        private Node work; // The purpose of this pointer is to access the information of a single node.

        public DoublyLinkedList()
        {
            head = new Node();
            head.Next = null;
            head.Previous = null;
        }

        // Display interface to compose a new mail
        public void ComposeMail()
        {
            Console.Clear();

            work = head;

            // If the DLL isn't empty, move "work" to the end
            while (work.Next != null)
                work = work.Next;

            // Temporal node to add the mail in the DLL later
            Node temp = new Node();

            // Title
            Console.WriteLine("+-------------------+");
            Console.WriteLine("     Compose mail    ");
            Console.WriteLine("+-------------------+\n");

            // Write the important elements of the mail
            Console.WriteLine("To:");
            string localTo = Console.ReadLine();
            Console.WriteLine("Subject:");
            string localSubject = Console.ReadLine();
            Console.WriteLine("Body of the mail:");
            string localBody = Console.ReadLine();

            // Assign the content of the email to the temporal node 
            temp.From = Program.userEmailAddress;
            temp.To = localTo;
            temp.Subject = localSubject;
            temp.Body = localBody;

            // Add the temporal node to the DLL
            temp.Next = null;
            temp.Previous = work;

            work.Next = temp;
        }

        // Alternative form to compose a new mail
        // This is just used to fill the "inbox" tag with some mails
        // If you want to compose a mail in the normal process, use the method "ComposeMail()"
        public void ComposeMailAlt(string localFrom, string localSubject, string localBody)
        {
            work = head;

            // If the DLL isn't empty, move "work" to the end
            while (work.Next != null)
                work = work.Next;

            // Temporal node to add the mail in the DLL later
            Node temp = new Node();

            // Assign the content of the email to the temporal node 
            temp.From = localFrom;
            temp.To = Program.userEmailAddress;
            temp.Subject = localSubject;
            temp.Body = localBody;

            // Add the temporal node to the DLL
            temp.Next = null;
            temp.Previous = work;

            work.Next = temp;
        }

        // Delete a selected mail

        private void DeleteMailDialog(Node mail)
        {
            bool exit = false;
            int option;

            do
            {
                // Title 
                Console.WriteLine("+------------------+");
                Console.WriteLine("     Delete mail    ");
                Console.WriteLine("+------------------+\n");

                // Ask the user if they want to delete the mail
                Console.WriteLine("Do you want to delete this mail?:\n[1] Yes\n[0] No");

                option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    // Yes
                    case 1:
                        DeleteMail(mail);
                        Console.WriteLine("Mail deleted");
                        Console.ReadKey();
                        exit = true;
                        break;

                    case 0:
                        exit = true;
                        break;
                }
            }
            while (!exit);
        }

        // Delete mail action
        private void DeleteMail(Node mail)
        {
            work.Previous.Next = work.Next;

            if (work.Next != null)
            {
                work.Next.Previous= work.Previous;
                work.Next= null;
            }

            work.Previous= null;
        }

        // Display interface to show and read each mail in certain DLL
        public void ShowMails()
        {
            if (head.Next != null)
            {
                bool exit = false;
                int option;
                int index = 1; // Indicates the index of the actual mail
                int totalMails = Quantity();

                work = head.Next;

                do
                {
                    Console.Clear();

                    // Title
                    Console.WriteLine("+------------------+");
                    Console.WriteLine("     Check mails    ");
                    Console.WriteLine("+------------------+\n");

                    // Shows the current index of the mail and the total amount of mails in the list
                    Console.WriteLine($"Mail {index} of {totalMails}\n");

                    // Prints the from, to, subject and body
                    Console.WriteLine("From: " + work.From + "\nTo: " + work.To + "\nSubject:\n" + work.Subject + "\nBody of the mail: \n" + work.Body);

                    // Show the options to do in the interface
                    Console.WriteLine("\nOptions:\n[1] Go to the previous mail\n[2] Go to the next mail\n[3] Delete mail\n[0] Return to home");

                    // Read the user's input
                    option = Int32.Parse(Console.ReadLine());

                    switch (option)
                    {
                        // Go previous mail
                        case 1:
                            if (work.Previous != head)
                            {
                                index--;
                                work = work.Previous;
                            }
                            break;

                        // Go next mail
                        case 2:
                            if (work.Next != null)
                            {
                                index++;
                                work = work.Next;
                            }
                            break;

                        // Delete mail
                        case 3:
                            DeleteMailDialog(work);
                            exit = true;
                            break;

                        // Return
                        case 0:
                            exit = true;
                            break;
                    }
                }
                while (!exit);
            }
            else
            {
                // If the list is empty, display the following strings
                Console.Clear();
                Console.WriteLine("There are no mails here...\nPress any key to exit");
                Console.ReadKey();
            }
        }
        
        // Returns the quantity of nodes in a list
        private int Quantity()
        {
            int quantity = 0;

            work = head;

            while (work.Next != null)
            {
                work = work.Next;
                quantity++; // For each time work makes a step in the list, increment quantity
            }

            return quantity;
        }
    }
}
