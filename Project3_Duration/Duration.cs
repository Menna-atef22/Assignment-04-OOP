using System;
using System.Collections.Generic;
using System.Text;

namespace Project3_Duration
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            if (Minutes > 0)
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
            return $"Seconds :{Seconds}";
        }

        public Duration(int totalSeconds)
        {
            if (totalSeconds < 0) totalSeconds = 0;   // no negative durations

            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        public int TotalSeconds
        {
            get { return Hours * 3600 + Minutes * 60 + Seconds; }
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return this.TotalSeconds == other.TotalSeconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return TotalSeconds;
        }



        //---------------------------------------------
        // ---------- Operators ----------

        // D3 = D1 + D2
        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration(a.TotalSeconds + b.TotalSeconds);
        }

        // D3 = D1 + 7800
        public static Duration operator +(Duration a, int seconds)
        {
            return new Duration(a.TotalSeconds + seconds);
        }

        // D3 = 666 + D3
        public static Duration operator +(int seconds, Duration a)
        {
            return new Duration(seconds + a.TotalSeconds);
        }

        // D1 = D1 - D2
        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration(a.TotalSeconds - b.TotalSeconds);
        }

        // D3 = ++D1   (adds one minute)
        public static Duration operator ++(Duration a)
        {
            return new Duration(a.TotalSeconds + 60);
        }

        // D3 = --D2   (subtracts one minute)
        public static Duration operator --(Duration a)
        {
            return new Duration(a.TotalSeconds - 60);
        }

        // if (D1 > D2)  /  if (D1 <= D2)   (they must come in pairs)
        public static bool operator >(Duration a, Duration b)
        {
            return a.TotalSeconds > b.TotalSeconds;
        }

        public static bool operator <(Duration a, Duration b)
        {
            return a.TotalSeconds < b.TotalSeconds;
        }

        public static bool operator >=(Duration a, Duration b)
        {
            return a.TotalSeconds >= b.TotalSeconds;
        }

        public static bool operator <=(Duration a, Duration b)
        {
            return a.TotalSeconds <= b.TotalSeconds;
        }

        // if (D1)   -> true when the duration is not zero
        public static bool operator true(Duration a)
        {
            return a.TotalSeconds > 0;
        }

        public static bool operator false(Duration a)
        {
            return a.TotalSeconds <= 0;
        }

        // DateTime Obj = (DateTime) D1
        public static explicit operator DateTime(Duration a)
        {
            return DateTime.Today.AddSeconds(a.TotalSeconds);
        }

    }
}
