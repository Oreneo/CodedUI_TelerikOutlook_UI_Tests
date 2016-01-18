using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Telerik.Outlook.Infrastructure.UIMaps.CalendarHomeBarUIMapClasses;
using Telerik.Outlook.Infrastructure.UIMaps.HomeMenuUIMapClasses;

namespace Telerik.Outlook.Infrastructure.Pages
{
    public class CalendarHomeBarPage
    {
        public CalendarHomeBarUIMap CalendarHomeBarUIMap { get; set; }

        public CalendarHomeBarPage()
        {
            CalendarHomeBarUIMap = new CalendarHomeBarUIMap();
        }

        public void ClickNewAppointmentButton()
        {
            var createNewApointmentButton = CalendarHomeBarUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UIRadRibbonViewTabList.UIHomeTabPage.UIAppointmentGroup.UICreateappointmentButton;
            Mouse.Click(createNewApointmentButton);
        }

        public void ClickDeleteAppointmentButton()
        {
            var deleteappointmentButton = CalendarHomeBarUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UIRadRibbonViewTabList.UIHomeTabPage.UIAppointmentGroup.UIDeleteappointmentButton;

            Mouse.Click(deleteappointmentButton, new Point(10, 10));
        }

        public void ClickDayViewButton()
        {
            var dayViewButton = CalendarHomeBarUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UIRadRibbonViewTabList.UIHomeTabPage.UIViewsGroup.UISetstheschedulersvieButton;

            Mouse.Click(dayViewButton, new Point(10, 10));
        }

        public void ClickWeekViewButton()
        {
            var viewsCustom = CalendarHomeBarUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UIRadRibbonViewTabList.UIHomeTabPage.UIViewsGroup.GetChildren()[0].GetChildren();

            var weekViewButton = viewsCustom[1];

            Mouse.Click(weekViewButton, new Point(10, 10));
        }

        public void ClickWorkViewButton()
        {
            var viewsCustom = CalendarHomeBarUIMap.UIMarktelerikdomaincomWindow.UIItemCustom.UIRadRibbonViewTabList.UIHomeTabPage.UIViewsGroup.GetChildren()[0].GetChildren();

            var weekViewButton = viewsCustom[2];

            Mouse.Click(weekViewButton, new Point(10, 10));
        }
    }
}
