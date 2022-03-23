using System;
using System.Collections.Generic;
using System.Text;

namespace Task_abstract
{
    internal class SmsSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine(" Sms ile mesaj gönderilmelidi");
        }

    }
}
