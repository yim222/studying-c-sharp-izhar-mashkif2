using System;
using System.Collections.Generic;
using System.Text;

namespace studying_c_sharp_izhar_mashkif.basic_objects { 
    public class AccessModifiers
    {
        public static void Demo()
        {
            MyDate myDate = new MyDate();
            //myDate.minute = 70;

            myDate.SetMinute(34);
            myDate.DisplayTime();

            myDate.SetMinute(70);
            myDate.DisplayTime();

            Console.WriteLine("Minute = " + myDate.GetMinute());



        }
    }

    public class MyDate
    {

        public int hour = 0;

        private int minute = 0;

        private string country;
        
        public void SetCountry(string country)
        {
            this.country = country;
        }

        public void SetMinute(int minute)
        {

            if (minute >= 0 && minute <= 59)
                this.minute = minute;
        }

        public int GetMinute()
        {
            return minute;
        }

        public void DisplayTime()
        {
            Console.WriteLine($"{hour}:{minute}");
        }


    }


}
