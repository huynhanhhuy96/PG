namespace PG.Services
{
    using System;
    using System.Collections.Generic;
    public class AdminServices
    {
        public void Admin_Load()
        {
            List<string> lstDay = new List<string> { " " };
            DateTime date = DateTime.Now;
            DateTime tempDate = DateTime.Now;
            int temp = (int)date.DayOfWeek;

            #region List2Week
            //Check Monday
            // if (date.DayOfWeek == DayOfWeek.Monday)
            // {
            //     lstDay.Add(date.ToString("M/d/yyyy"));
            //     date = date.AddDays(+1);
            // }

            // Now => Sunday
            // while (date.DayOfWeek != DayOfWeek.Monday)
            // {
            //     lstDay.Add(date.ToString("M/d/yyyy"));
            //     date = date.AddDays(+1);
            // }

            // Monday => Now-1
            // while (date.DayOfWeek != tempDate.DayOfWeek)
            // {
            //     lstDay.Add(date.ToString("M/d/yyy"));
            //     date = date.AddDays(+1);
            // }
            #endregion

            do
            {
                lstDay.Add(date.ToString("M/d/yyy"));
                date = date.AddDays(+1);
            }while (date.DayOfWeek != tempDate.DayOfWeek);
        }
    }
}