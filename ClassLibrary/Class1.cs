using System;

namespace ClassLibrary
{
    public class Notification
    {
        // private protected string Message { get; set; }
         protected internal string Message { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Mesaj gonderildi");
        }
    }
    class test:Notification
    {
       
        public void Lorem()
        {
            Message = "TEST";
            Notification notification = new Notification();
            //notification.

        }

    }
}
