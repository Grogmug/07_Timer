using System;
namespace _07_Timer
{
    internal class Timer
    {
        private int seconds;

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public string Padded(int number)
        {
            if (number.ToString().Length == 1)
            {
                return "0" + number;
            }
            else
            {
                return number.ToString();
            }
        }
            

        public override string ToString()
        {
            int sec = seconds % 60;
            int min = (seconds / 60) % 60;
            int hour = (seconds / 60) / 60;

            return Padded(hour) + ":"+ Padded(min) + ":"+ Padded(sec);
            
        }
    }
}