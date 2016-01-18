using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Telerik.Outlook.Infrastructure.UIMaps.CalendarUIMapClasses;

namespace Telerik.Outlook.Infrastructure.Pages
{
    public class CalendarPage
    {
        public CalendarUIMap CalendarUIMap { get; set; }

        public CalendarPage()
        {
            CalendarUIMap = new CalendarUIMap();
        }

        public void ClickCalendarBody()
        {
            CalendarUIMap.ClickDay();
        }

        public bool FindNewAppointment(string appointmentSubject)
        {
            UITestControlCollection calendarView = CalendarUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UICalendarScheduleViewCustom.GetChildren();

            return calendarView.Any(calendarViewItem => calendarViewItem.FriendlyName.StartsWith(appointmentSubject));
        }

        public void ClickAppointment(string appointmentSubject)
        {
            UITestControlCollection calendarView = CalendarUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UICalendarScheduleViewCustom.GetChildren();

            UITestControl appointmentToDelete = null;

            foreach (var item in calendarView)
            {
                if (item.FriendlyName.StartsWith(appointmentSubject))
                {
                    appointmentToDelete = item;
                }
            }

            Mouse.Click(appointmentToDelete, new Point(10, 10));
        }

        public void ClickDeleteOkButton()
        {
            WpfButton okButton = CalendarUIMap.UIMarktelerikdomaincomWindow.UIOKButton;

            Mouse.Click(okButton, new Point(10, 10));
        }
    }
}
