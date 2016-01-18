using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Telerik.Outlook.Infrastructure.UIMaps.NavBarUIMapClasses;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System.Drawing;

namespace Telerik.Outlook.Infrastructure.Pages
{
    public class NavigationBarPage
    {
        internal NavBarUIMap NavBarUIMap { get; set; }

        public NavigationBarPage()
        {
            NavBarUIMap = new NavBarUIMap();
        }

        public void ClickSentItemsFolder()
        {
            NavBarUIMap.ClickSentItemsFolder();
        }

        public void ClickDeletedItemsFolder()
        {
            NavBarUIMap.ClickDeletedItemsFolder();
        }

        public void ClickCalendarTab()
        {
            WpfCustom calendarTab = NavBarUIMap.UIMarktelerikdomaincomWindowMail.UIItemCustom.UIOutlookBarCustom.UIRadOutlookBarItemCustomCalendar;

            if (calendarTab.TryFind())
            {
                Mouse.Click(calendarTab, new Point(98, 17));
            }
        }
    }
}
