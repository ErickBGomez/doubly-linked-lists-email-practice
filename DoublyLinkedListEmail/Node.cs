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
    class Node
    {
        // Create every variable the node will storage in its content
        private string from;
        private string to;
        private string subject;
        private string body;
        private Node previous = null, next = null;

        // Create Properties that will help the variables to be accessed in every part of the project with more security
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Body { get => body; set => body = value; }
        public Node Previous { get => previous; set => previous = value; }
        public Node Next { get => next; set => next = value; }

        // This override its just for debugging cases. If I want to see the content of a node, I just need to call the node itself in a Console.WriteLine()
        public override string ToString()
        {
            return String.Format($"[{from}, {to}, {subject}, {body}]");
        }
    }
}
