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

            // Later, find a way to change these lines of codes to something easier to manipulate
            inbox.ComposeMailAlt("test@gmail.com", "Important message", "This is a more or less long message, just to let you know that I am really enjoying doing this project! Next, I warn you that the following message will only contain a Lorem Ipsum so you can see the length that a message can contain and be displayed on the screen.");
            inbox.ComposeMailAlt("support@fictionaldomain.com", "System support", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed consectetur leo eget commodo fringilla. In nec facilisis ex. Quisque tempus blandit lacus eu congue. Sed vitae eleifend felis, et ornare mi. Aenean quis auctor mi, at finibus massa. Fusce eu eros eu sapien tincidunt viverra. In id sodales velit, vitae eleifend quam. Nulla id mi velit. Duis tempus, diam at congue gravida, lorem elit finibus lorem, vel auctor neque elit quis orci. Sed quam nibh, dapibus quis nisi vel, viverra ultrices quam. Morbi quis tristique nisi. Phasellus et lobortis eros.");
            inbox.ComposeMailAlt("erick@thisemail.com", "A message for you!", "Hello! This is Erick B. Gómez, thank you very much for downloading and trying my project! I am practically novice to GitHub, because, although I have created my account since last year, there have been few times that I have started to explore the functionality of this platform. Now, I'm getting used to it and I'm learning a lot! I hope to be able to continue doing more projects in the future, and I hope that you, who are reading this message, can support me on this beautiful journey as a programmer. I hope you have a happy day :D");

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

            Console.WriteLine("\nExiting the system. Thank you for using our services.\nMade with <3 by Erick B. Gómez");
            Console.ReadKey();
        }
    }
}
