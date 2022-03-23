using System;

namespace Task_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailSender emailSender = new EmailSender();
            SmsSender smsSender = new SmsSender();

            Console.WriteLine("1. Send message by email");
            Console.WriteLine("2. Send message by sms");
            Console.WriteLine("0. Quit");
            Console.Write("Enter  number:");


            switch (Convert.ToInt32( Console.ReadLine()))
            {
                case 1:
                     emailSender.SendMessage();
                    break;

                case 2:
                    smsSender.SendMessage();
                    break;

                case 0:
                    Console.WriteLine("Quit");
                    break;

                default:
                    Console.WriteLine("duzgun eded daxil edin");
                    break;

            }
        }
    }
}

