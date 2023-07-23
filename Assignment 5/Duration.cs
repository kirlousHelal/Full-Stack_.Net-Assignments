using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Duration
    {

        int hours;
        int minutes;
        int seconds;

        public int Hours { get => hours; set => hours = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }

        public Duration(int _hours, int _minutes, int _seconds)
        {
            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
        }
        public Duration(int _seconds)
        {
            this.hours= _seconds/(60*60);
            this.minutes= _seconds/60 - (this.hours*60);
            this.seconds = _seconds%60;
        }

        public override bool Equals(object? obj)
        {
            Duration dr = obj as Duration;
            //Duration dr= (Duration)obj ;
            if (this.hours == dr.Hours && this.minutes == dr.minutes && this.seconds == dr.seconds)
                return true;
            return false;

        }
        public override string ToString()
        {
            return $"Hours: {this.hours}, Minutes :{this.minutes}, Seconds :{this.seconds}";
        }


        public static Duration operator +(Duration d1, Duration d2)
        {
            int sec = d1.seconds + d2.seconds;
            int min= d1.minutes + d2.minutes;
            int hour= d1.hours + d2.hours;
            while (sec >= 60) { sec -= 60; min++; }
            while (min >= 60) { min -= 60; hour++; }

            return new Duration(hour, min, sec);
        } 
        
        public static Duration operator +(Duration d1, int _sec)
        {
            Duration d2 = new Duration(_sec);
            int sec = d1.seconds + d2.seconds;
            int min= d1.minutes + d2.minutes;
            int hour= d1.hours + d2.hours;
            while (sec >= 60) { sec -= 60; min++; }
            while (min >= 60) { min -= 60; hour++; }

            return new Duration(hour, min, sec);
        }
        public static Duration operator +(int _sec,Duration d1)
        {
            Duration d2 = new Duration(_sec);
            int sec = d1.seconds + d2.seconds;
            int min = d1.minutes + d2.minutes;
            int hour = d1.hours + d2.hours;
            while (sec >= 60) { sec -= 60; min++; }
            while (min >= 60) { min -= 60; hour++; }

            return new Duration(hour, min, sec);
        }


    }
}
