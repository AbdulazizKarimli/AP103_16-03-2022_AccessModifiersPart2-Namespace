using AccessModifiersPart2.Models.Test;
using ClassLibrary;
using System;

namespace AccessModifiersPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region access modifiers
            //internal 
            //Book book= new Book();
            //Notification notification = new Notification();

            //notification.SendMessage();

            //protected-internal
            //private-protected\
            #endregion

            #region namespace
            //Car car1 = new Car();
            //Models.Car car2 = new Models.Car();
            //AccessModifiersPart2.Models.Test.Car car3 = new Models.Test.Car();
            //car2.Speed
            #endregion

        }
    }
    class Car
    {

    }
   
}


