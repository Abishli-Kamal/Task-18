using System;
using System.Collections.Generic;
using System.Text;

namespace Task_abstract
{
    internal class EmailSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine(" Email ile mesaj gönderilmelidi"); 
        }
    }
}
