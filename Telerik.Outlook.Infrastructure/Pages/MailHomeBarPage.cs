using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.Outlook.Infrastructure.UIMaps.HomeMenuUIMapClasses;

namespace Telerik.Outlook.Infrastructure.Pages
{
    public class MailHomeBarPage
    {
        internal HomeMenuUIMap HomeMenuUIMap { get; set; }

        public MailHomeBarPage()
        {
            HomeMenuUIMap = new HomeMenuUIMap();
        }

        public void ClickNewEmailButton()
        {
            var newEmailButton = HomeMenuUIMap.UIMarktelerikdomaincomWindowWrapper.UIMarktelerikdomaincomWindow.UIRadRibbonViewTabList.UIHomeTabPage.UINewGroup.UIRadRibbonButtonButton;
            Mouse.Click(newEmailButton);
        }

        public void ClickDeleteMail()
        {
            HomeMenuUIMap.ClickDeleteMail();
        }

        public void WaitForDeleteButtonToExist()
        {
            WpfButton deleteButton = HomeMenuUIMap.UIMarktelerikdomaincomWindowWrapper.UIMarktelerikdomaincomWindow.UIRadRibbonViewTabList.UIHomeTabPage.UIDeleteGroup.UIRadRibbonButtonButton;

            deleteButton.WaitForControlExist();
        }

        public void ClickFollowUpDropdown()
        {
            var dropdownsGroup = HomeMenuUIMap.UIMarktelerikdomaincomWindowWrapper.UIMarktelerikdomaincomWindow.UIRadRibbonViewTabList.UIHomeTabPage.UITagsGroup.GetChildren()[0];

            var followUpDropdown = dropdownsGroup.GetChildren()[2];

            followUpDropdown.WaitForControlExist();

            Mouse.Click(followUpDropdown, new Point(10, 10));
        }

        public void ClickFollowUpTag(string flagName)
        {
            var dropdownsGroup = HomeMenuUIMap.UIMarktelerikdomaincomWindowWrapper.UIMarktelerikdomaincomWindow.UIRadRibbonViewTabList.UIHomeTabPage.UITagsGroup.GetChildren()[0];

            var followUpDropdown = dropdownsGroup.GetChildren()[2];

            var followUpDropdownMenu = followUpDropdown.GetChildren()[0];

            var followUpDropdownMenuItems = followUpDropdownMenu.GetChildren();

            foreach (var flag in followUpDropdownMenuItems)
            {
                if (flag.FriendlyName == flagName)
                {
                    Mouse.Click(flag, new Point(10, 10));
                    break;
                }
            }
        }
    }
}
