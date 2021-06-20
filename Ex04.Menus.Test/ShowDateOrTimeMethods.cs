using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateOrTimeMethods
    {
        public class ShowDate : IClickReporter
        {
            public void ReportActionClicked()
            {
                showDate();
            }

            private void showDate()
            {
                DateTime thisDay = DateTime.Now;
                string todayDate = thisDay.ToString().Split(' ')[0];

                Console.WriteLine("This day date is: {0} ", todayDate);
            }
        }

        public class ShowTime : IClickReporter
        {
            public void ReportActionClicked()
            {
                showTime();
            }

            private void showTime()
            {
                DateTime thisDay = DateTime.Now;
                string todayTime = thisDay.ToString().Split(' ')[1];

                Console.WriteLine("The time now is: {0} ", todayTime);
            }
        }
    }
}
